using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class clsGame
    {
        public enum enResult { Win, Draw, TBD };
        public enum enGameMode { InProgress, GameOver };
        public enum enCurrentPlayer { Player1, Player2 };
        public enum enBoxValue { X, O, Empty };

        private enResult _Result;
        private enGameMode _GameMode;
        private enCurrentPlayer _CurrentPlayer;
        private List<enBoxValue> _enBoxValues = new List<enBoxValue>();
        private List<byte> _WinningIndexes;

        private void InitializeListOfBoxesWithEmptyValues()
        {
            for (int i = 0; i < 9; i++)
            {
                _enBoxValues.Add(enBoxValue.Empty);
            }
        }

        public clsGame()
        {
            _Result = enResult.TBD;
            _GameMode = enGameMode.InProgress;
            _CurrentPlayer = enCurrentPlayer.Player1;
            InitializeListOfBoxesWithEmptyValues();
            _WinningIndexes = new List<byte>();
        }

        private void SetWinningIndexes(byte box1, byte box2, byte box3)
        {
            _WinningIndexes.Add(box1);
            _WinningIndexes.Add(box2);
            _WinningIndexes.Add(box3);
        }

        public void GetWinningIndexes(ref List<byte> winningIndexes)
        {
            winningIndexes = _WinningIndexes;
        }

        public enCurrentPlayer GetCurrentPlayer()
        {
            return _CurrentPlayer;
        }

        public enGameMode GetGameMode()
        {
            return _GameMode;
        }

        public enResult GetGameResultResult()
        {
            return _Result;
        }

        public void SetCurrentPlayer(enCurrentPlayer currentPlayer)
        {
            _CurrentPlayer = currentPlayer;
        }

        public void SetGameMode(enGameMode gameMode)
        {
            _GameMode = gameMode;
        }

        public void SetResult(enResult result)
        {
            _Result = result;
        }

        public void ChangeCurrentPlayer()
        {
            _CurrentPlayer = _Result == enResult.TBD ?
                _CurrentPlayer == enCurrentPlayer.Player1 ?
                enCurrentPlayer.Player2 : enCurrentPlayer.Player1
                : _CurrentPlayer;
        }

        public enBoxValue GetPlayerBoxValue(enCurrentPlayer currentPlayer)
        {
            return currentPlayer == enCurrentPlayer.Player1 ? enBoxValue.X : enBoxValue.O;
        }

        public enBoxValue GetBoxValue(byte boxIndex)
        {
            return _enBoxValues[boxIndex - 1];
        }

        public enCurrentPlayer GetWinner(enBoxValue boxValue)
        {
            return boxValue == enBoxValue.X ? enCurrentPlayer.Player1 : enCurrentPlayer.Player2;
        }

        public enGameMode GetCurrentGameMode()
        {
            return _Result == enResult.TBD ? enGameMode.InProgress : enGameMode.GameOver;
        }

        public enResult GetGameResult()
        {
            byte counter = 0;
            if ((_enBoxValues[0] != enBoxValue.Empty &&
                _enBoxValues[0] == _enBoxValues[4] &&
                _enBoxValues[0] == _enBoxValues[8]))
            {
                SetWinningIndexes(0, 4, 8);
                return enResult.Win;
            }
            else if ((_enBoxValues[2] != enBoxValue.Empty &&
                _enBoxValues[2] == _enBoxValues[4] &&
                _enBoxValues[2] == _enBoxValues[6]))
            {
                SetWinningIndexes(2, 4, 6);
                return enResult.Win;
            }
            for (byte i = 0; i < _enBoxValues.Count; i++)
            {
                if (_enBoxValues[i] == enBoxValue.Empty)
                    counter++;
                else if (_enBoxValues[i] != enBoxValue.Empty)
                {
                    if (i < 3)
                    {
                        if (((_enBoxValues[i] == _enBoxValues[i + 3]) &&
                            (_enBoxValues[i] == _enBoxValues[i + 6])))
                        {
                            SetWinningIndexes(i, (byte)(i + 3), (byte)(i + 6));
                            return enResult.Win;
                        }
                    }
                    if ((i + 1) % 3 == 1)
                    {
                        if (((_enBoxValues[i] == _enBoxValues[i + 1]) &&
                            (_enBoxValues[i] == _enBoxValues[i + 2])))
                        {
                            SetWinningIndexes(i, (byte)(i + 1), (byte)(i + 2));
                            return enResult.Win;
                        }
                    }
                }
            }
            return counter > 0 ? enResult.TBD : enResult.Draw;
        }

        public bool PlayTurn(byte boxIndex)
        {
            if (_enBoxValues[boxIndex - 1] == enBoxValue.Empty)
            {
                _enBoxValues[boxIndex - 1] = GetPlayerBoxValue(_CurrentPlayer);
                if (GetGameResult() == enResult.TBD)
                    ChangeCurrentPlayer();
                else if (GetGameResult() == enResult.Win)
                    _CurrentPlayer = GetWinner(GetPlayerBoxValue(_CurrentPlayer));
                SetResult(GetGameResult());
                return true;
            }
            return false;
        }
    }
}
