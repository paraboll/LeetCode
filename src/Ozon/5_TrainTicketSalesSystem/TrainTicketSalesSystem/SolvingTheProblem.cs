using System;
using System.Collections.Generic;
using System.Linq;

namespace TrainTicketSalesSystem
{
    public class SolvingTheProblem
    {
        //Нет заполнения.
        private Dictionary<int, Room> _trainСar = new Dictionary<int, Room>();
        private int _trainСarSize = 10;

        public Dictionary<int, Room> ManagerSystem(string command, int param)
        {
            if(command == "занять")
            {
                TakeSeat(param);
            }
            if (command == "освободить")
            {
                FreeUpSeat(param);
            }
            if(command == "занятьКупе")
            {
                TakeRoom();
            }

            return null;
        }

        private void TakeSeat(int param)
        {
            int numberCupe = param / 2;
            if (numberCupe > _trainСarSize)
            {
                return;
            }

            if (param % 2 == 0 && _trainСar[numberCupe].Seat1 == "S")
            {
                _trainСar[numberCupe].Seat1 = "Z";
            }
            else if (param % 2 == 1 && _trainСar[numberCupe].Seat2 == "S")
            {
                _trainСar[numberCupe].Seat2 = "Z";
            }
        }

        private void FreeUpSeat(int param)
        {
            int numberCupe = param / 2;
            if (numberCupe > _trainСarSize)
            {
                return;
            }

            if (param % 2 == 0 && _trainСar[numberCupe].Seat1 == "Z")
            {
                _trainСar[numberCupe].Seat1 = "S";
            }
            else if (param % 2 == 1 && _trainСar[numberCupe].Seat2 == "Z")
            {
                _trainСar[numberCupe].Seat2 = "S";
            }
        }

        private void TakeRoom()
        {
            foreach (var item in _trainСar)
            {
                if (item.Value.isFree())
                {
                    item.Value.Seat1 = "Z";
                    item.Value.Seat2 = "Z";
                    return;
                }
            }
        }

        public Dictionary<int, Room> GetTrainСar()
        {
            return _trainСar;
        }

        public class Room
        {
            public string Seat1 { get; set; } = "S";
            public string Seat2 { get; set; } = "S";
            public bool isFree()
            {
                if(Seat1 == "S" && Seat2 == "S")
                {
                    return true;
                }

                return false;
            }
        }
    }
}
