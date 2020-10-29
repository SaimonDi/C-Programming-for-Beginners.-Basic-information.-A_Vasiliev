using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeSweetHome {
    public partial class Form1 : Form {
        Location currentLocation;

        RoomWithDoor livingRoom;
        Room dinningRoom;
        RoomWithDoor kitchen;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        Outside garden;

        public Form1() {
            InitializeComponent();
            CreateObjects();
            MoveToANewLocation(livingRoom);
            }

        private void CreateObjects() {
            livingRoom = new RoomWithDoor("Гостиная", "старинный ковер", "дубовая дверь с латунной ручкой");
            kitchen = new RoomWithDoor("Кухня", "плита из нержавеющей стали", "сетчатая дверь");
            dinningRoom = new Room("Столовая", "хрустальная люстра");

            frontYard = new OutsideWithDoor("Лужайка", false, "дубовая дверь с латунной ручкой");
            backYard = new OutsideWithDoor("Задний двор", true, "сетчатая дверь");
            garden = new Outside("Сад", false);

            livingRoom.Exits = new Location[] { dinningRoom };
            kitchen.Exits = new Location[] { dinningRoom };
            dinningRoom.Exits = new Location[] { livingRoom, kitchen };

            frontYard.Exits = new Location[] { backYard, garden };
            backYard.Exits = new Location[] { frontYard, garden };
            garden.Exits = new Location[] { backYard, frontYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;

            }

        private void MoveToANewLocation(Location newLocation) {
            currentLocation = newLocation;

            exits.Items.Clear();
            for(int i = 0; i < currentLocation.Exits.Length; i++)
                exits.Items.Add(currentLocation.Exits[i].Name);
            exits.SelectedIndex = 0;

            description.Text = currentLocation.Description;

            if(currentLocation is IHasExteriorDoor)
                goThroughTheDoor.Visible = true;
            else
                goThroughTheDoor.Visible = false;
            }

        

        private void goHere_Click(object sender, EventArgs e) {
            MoveToANewLocation(currentLocation.Exits[exits.SelectedIndex]);
            }

        private void goThroughTheDoor_Click(object sender, EventArgs e) {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
            }
        }
    }
