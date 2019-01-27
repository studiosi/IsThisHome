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
            IsAlive = true;
            GameCompleted = false;
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
            Rooms.Add(2, new AirlockRoom());
            Rooms.Add(3, new NoReturnRoom());
            Rooms.Add(4, new MemoriesRoom());
            Rooms.Add(5, new VisionRoom());
            Rooms.Add(6, new CornFieldsRoom());
            Rooms.Add(7, new RedDustGloryRoom());
            Rooms.Add(8, new GeneralCallRoom());
            Rooms.Add(9, new ScottBeamRoom());
            Rooms.Add(10, new GeneralDirectionsRoom());
            Rooms.Add(11, new RedPlanetSplendourRoom());
            Rooms.Add(12, new ElectricMalfunction1Room());
            Rooms.Add(13, new ElectricMalfunction2Room());
            Rooms.Add(14, new PositiveSampleRoom());
            Rooms.Add(15, new MartianSunriseRoom());
            Rooms.Add(16, new DeathRoom());
            Rooms.Add(17, new ICanReturnRoom());
            Rooms.Add(18, new WaterIsGoneRoom());
            Rooms.Add(19, new ClimbHillRoom());
            Rooms.Add(20, new ViewOverPlainsRoom());
            Rooms.Add(21, new Airlock2Room());
            Rooms.Add(22, new EndRoom());
        }

        public IRoom CurrentRoom { get; set; }
        public Inventory Objects { get; set; }
        public bool GameCompleted { get; set; }
        public bool IsAlive { get; set; }
        public Dictionary<int, IRoom> Rooms {get;set;}
    }
}
