using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.OurServer;

namespace Client
{
    public class ClientCallback : Client.OurServer.IGameServerCallback
    {
        GameServerClient server;
        public Action LoginSuccessed = null;
        public Action<string> Message = null;
        public Action<int> UpdateCount = null;
        public Action<string[]> UpdateClientRoom = null;

        public ClientCallback()
        {
            server = new GameServerClient(new System.ServiceModel.InstanceContext(this));
        }

        public void Login(string name, string pass)
        {
            server.Login(name, pass);
        }
        public void Registration(string name, string pass)
        {
            server.Registration(name, pass);
        }

        public void UpdateMap(byte[][] map)
        {
            throw new NotImplementedException();
        }

        public void RecieveMessage(string msg)
        {
            if (Message != null)
            {
                Message(msg);
            }
        }

        public void LoginSuccess()
        {
            if (LoginSuccessed != null)
            {
                LoginSuccessed();
            }
        }

        public void UpdateUsersCount(int count)
        {
            if (UpdateCount != null)
            {
                UpdateCount(count);
            }
        }

        public void UpdateRooms(string[] rooms)
        {
            if (UpdateClientRoom != null)
            {
                UpdateClientRoom(rooms);
            }
        }

        public void RoomEnterSuccessful()
        {
            throw new NotImplementedException();
        }

        public void RoomLeaveSuccessful()
        {
            throw new NotImplementedException();
        }

        public void UpdatePlayersList(string[] names)
        {
            throw new NotImplementedException();
        }

        public void IsAdmin(bool IsEnabled)
        {
            throw new NotImplementedException();
        }

        public void GameStartSuccess()
        {
            throw new NotImplementedException();
        }
    }
}
