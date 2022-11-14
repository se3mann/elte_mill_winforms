using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mill.Persistence;

namespace Mill.Model
{
    public enum Player { Player1, Player2 }
    public enum GamePhase { Phase1, Phase2 }
    public enum Action { Adding, MoveDest, MoveTarget, Removing}
    public class MillGameModel
    {
        #region Fields
        private MillTable _table;
        private Player _currentPlayer;
        private Boolean _currentPlayerWon;
        private GamePhase _currentPhase;
        private int _lastField;
        private Action _currentAction;
        #endregion

        #region Properties
        public Player CurrentPlayer { get { return _currentPlayer; } }
        public MillTable Table { get { return _table; } }
        public Boolean IsGameOver { get { return (_currentPlayerWon); } }
        public int LastField { get { return _lastField; } set { _lastField = value; } }
        public Action CurrentAction { get { return _currentAction; } set { _currentAction = value; } }
        public GamePhase CurrentPhase { get { return _currentPhase; } set { _currentPhase = value; } }
        public bool CurrentPlayerWon { get { return _currentPlayerWon; } set { _currentPlayerWon = value; } }
        #endregion

        #region Events
        public event EventHandler<MillEventArgs> GameOver;
        public event EventHandler<MillEventArgs> GameAdvanced;
        #endregion

        #region Constructor
        public MillGameModel()
        {
            _table = new MillTable();
            _currentPlayer = Player.Player1;
            _currentPlayerWon = false;
            _currentPhase = GamePhase.Phase1;
        }
        #endregion

        #region Public methods
        public void NewGame()
        {
            _table = new MillTable();
            _currentPlayer = Player.Player1;
            _currentPlayerWon = false;
            _currentPhase = GamePhase.Phase1;
            _currentAction = Action.Adding;
        }

        public void step(int field)
        {
            if (_currentPhase == GamePhase.Phase1) //we can only add or remove token
            {
                if (CurrentAction == Action.Adding) AddTokenFromTalon(field);
                if (CurrentAction == Action.Removing)
                {
                    RemoveToken(field);
                }
                //after action, check if new phase happened
                if (_table.Player1UnusedToken == 0 && _table.Player2UnusedToken == 0)
                {
                    CurrentPhase = GamePhase.Phase2;
                    CurrentAction = Action.MoveDest;
                }
            }
            else //we can only move or remove token
            {
                if (CurrentAction == Action.MoveDest) MoveToTargetNextStep(field);
                if (CurrentAction == Action.MoveTarget) MoveToTarget(field);
                if (CurrentAction == Action.Removing)
                {
                    RemoveToken(field);
                }
            }
            OnGameAdvanced();
        }
        #endregion

        #region Private methods
        private void MoveToTarget(int field)
        {
            if (CurrentPlayer == Player.Player1)
            {
                if (_table.Fields[field].Player == 0 && _table.Fields[LastField].Neighbours.Contains(field))
                {
                    _table.Fields[LastField].Player = 0;
                    _table.Fields[field].Player = 1;
                    if (_table.CheckFieldInMill(1, field))
                    {
                        RemoveTokenNextStep();
                    }
                    else
                    {
                        SwapPlayer();
                        CurrentAction = Action.MoveDest;
                    }
                }
            }
            else
            {
                if (_table.Fields[field].Player == 0 && _table.Fields[LastField].Neighbours.Contains(field))
                {
                    _table.Fields[LastField].Player = 0;
                    //have to notify view to remove LastField
                    _table.Fields[field].Player = 2;
                    if (_table.CheckFieldInMill(1, field))
                    {
                        RemoveTokenNextStep();
                    }
                    else
                    {
                        SwapPlayer();
                        CurrentAction = Action.MoveDest;
                    }
                }
            }
        }
        private void MoveToTargetNextStep(int field)
        {
            if (CurrentPlayer == Player.Player1)
            {
                if (_table.Fields[field].Player == 1 && CheckFieldMovable(field))
                {
                    LastField = field;
                    CurrentAction = Action.MoveTarget;
                }
            }
            else
            {
                if (_table.Fields[field].Player == 2 && CheckFieldMovable(field))
                {
                    LastField = field;
                    CurrentAction = Action.MoveTarget;
                }
            }
        }
        private void AddTokenFromTalon(int field)
        {
            if (_currentPlayer == Player.Player1)
            {
                if (_table.Fields[field].Player == 0 && _table.Player1UnusedToken > 0)
                {
                    _table.Fields[field].Player = 1;
                    _table.Player1UnusedToken--;
                    _table.Player1TokenInTable++;
                    if (_table.CheckFieldInMill(1, field))
                    {
                        RemoveTokenNextStep();
                    } 
                    else
                    {
                        SwapPlayer();
                        CurrentAction = Action.Adding;
                    }
                }
            }
            else
            {
                if (_table.Fields[field].Player == 0 && _table.Player2UnusedToken > 0)
                {
                    _table.Fields[field].Player = 2;
                    _table.Player2UnusedToken--;
                    _table.Player2TokenInTable++;
                    if (_table.CheckFieldInMill(2, field))
                    {
                        RemoveTokenNextStep();
                    }
                    else
                    {
                        SwapPlayer();
                        CurrentAction = Action.Adding;
                    }
                }
            }
        }

        private void RemoveToken(int field)
        {
            if (_currentPlayer == Player.Player1)
            {
                if (_table.Fields[field].Player == 2 && !_table.CheckFieldInMill(2, field))
                {
                    _table.Fields[field].Player = 0;
                    _table.Player2TokenInTable--;
                    CheckCurrentPlayerWon();
                    if (!IsGameOver) SwapPlayer();
                    SetActionAfterRemove();
                }
            }
            else
            {
                if (_table.Fields[field].Player == 1 && !_table.CheckFieldInMill(1, field))
                {
                    _table.Fields[field].Player = 0;
                    _table.Player1TokenInTable--;
                    CheckCurrentPlayerWon();
                    if (!IsGameOver) SwapPlayer();
                    SetActionAfterRemove();
                }
            }
        }

        private void SwapPlayer()
        {
            if (_currentPlayer == Player.Player1)
            {
                _currentPlayer = Player.Player2;
                _table.LastPlayer = 1; 
            }
            else
            {
                _currentPlayer = Player.Player1;
                _table.LastPlayer = 2;
            }
        }

        private void SetGamePhase()
        {
            if (_table.Player1UnusedToken == 0 && _table.Player2UnusedToken == 0) _currentPhase = GamePhase.Phase2;
            else _currentPhase = GamePhase.Phase1;
        }

        private void RemoveTokenNextStep()
        {
            _currentAction = Action.Removing;
        }

        private void SetActionAfterRemove()
        {
            if (CurrentPhase == GamePhase.Phase1) CurrentAction = Action.Adding;
            else CurrentAction = Action.MoveDest;
        }

        private void OnGameOver()
        {
            CurrentPlayerWon = true;
            GameOver(this, new MillEventArgs(CurrentPlayer, true, CurrentAction, _table.Player1UnusedToken, _table.Player2UnusedToken));
        }

        private void OnGameAdvanced()
        {
            GameAdvanced(this, new MillEventArgs(CurrentPlayer, false, CurrentAction, _table.Player1UnusedToken, _table.Player2UnusedToken));
        }

        private void CheckCurrentPlayerWon()
        {
            if (CurrentPlayer == Player.Player1)
            {
                if (_table.Player2TokenInTable + _table.Player2UnusedToken < 3)
                {
                    OnGameOver();
                }
            }
            else
            {
                if (_table.Player1TokenInTable + _table.Player1UnusedToken < 3)
                {
                    OnGameOver();
                }
            }
        }

        private bool CheckFieldMovable(int field)
        {
            bool retval = false;
            foreach (int i in _table.Fields[field].Neighbours)
            {
                retval = retval || _table.Fields[i].Player == 0;
            }
            return retval;
        }
        #endregion
    }
}
