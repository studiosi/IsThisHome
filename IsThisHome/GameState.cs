using IsThisHome.Rooms;
using System.Collections.Generic;

namespace IsThisHome
{
    public class GameState
    {

        public GameState()
        {
            Objects = new Inventory();
            LoadRooms();
            CurrentRoom = Rooms[0];
        }

        public void GoToRoom(int roomId)
        {
            CurrentRoom = Rooms[roomId];
        }

        public void LoadRooms()
        {
            Rooms = new Dictionary<int, IRoom>();
            Rooms.Add(0, new TitleRoom());
            Rooms.Add(1, new SuitRoom());
            Rooms.Add(2, new NoReturnRoom());
        }

        public IRoom CurrentRoom { get; set; }
        public Inventory Objects { get; set; }
        public bool GameCompleted { get; set; }
        public Dictionary<int, IRoom> Rooms {get;set;}
    }
}
