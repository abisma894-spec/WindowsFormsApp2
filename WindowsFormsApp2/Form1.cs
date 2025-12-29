using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        enum ElevatorState
        {
            Idle,
            MovingUp,
            MovingDown,
            DoorOpen,
            DoorClosed
        }

        ElevatorState currentState = ElevatorState.Idle;

        int currentFloor = 1;
        int targetFloor = 1;
        bool doorOpen = false;

        int currentFloor2 = 3;
        int targetFloor2 = 3;
        bool doorOpen2 = false;

        ElevatorState currentState2 = ElevatorState.Idle;


        // Y positions of floors
        int floor1Y;
        int floor2Y;
        int floor3Y;


        public Form1()
        {
            InitializeComponent();
            floor1Y = panelShaft.Height - panelElevator.Height;
            floor2Y = (panelShaft.Height / 2) - (panelElevator.Height / 2);
            floor3Y = 0;
            panelElevator2.Top = floor3Y;

            UpdateUI();

            panelDoorLeft.BringToFront();
            panelDoorRight.BringToFront();

            panelDoorLeft2.BringToFront();
            panelDoorRight2.BringToFront();

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int requestFloor = currentFloor; // jahan user khara hai
            if (requestFloor < 3)
                CallNearestElevator(requestFloor + 1);

        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int requestFloor = currentFloor;
            if (requestFloor > 1)
                CallNearestElevator(requestFloor - 1);
        }

        private void btnFloor1_Click(object sender, EventArgs e)
        {
            MoveElevator1(1);

        }

        private void btnFloor2_Click(object sender, EventArgs e)
        {
            MoveElevator1(2);

        }

        private void btnFloor3_Click(object sender, EventArgs e)
        {
            MoveElevator1(3);

        }

        private void btnDoor_Click(object sender, EventArgs e)
        {
            if (!doorOpen)
                OpenDoor();
            else
                CloseDoor();
        }

        private void timerElevator_Tick(object sender, EventArgs e)
        {
            int targetY = GetFloorY(targetFloor);

            if (panelElevator.Top < targetY)
            {
                panelElevator.Top += 2;
                UpdateMovingFloor();
            }
            else if (panelElevator.Top > targetY)
            {
                panelElevator.Top -= 2;
                UpdateMovingFloor();
            }
            else
            {
                timerElevator.Stop();
                currentFloor = targetFloor;
                currentState = ElevatorState.Idle;
                UpdateUI();
            }
        }
        void UpdateMovingFloor()
        {
            int y = panelElevator.Top;

            if (y >= floor2Y + 30)
                currentFloor = 1;
            else if (y >= floor3Y + 30)
                currentFloor = 2;
            else
                currentFloor = 3;

            UpdateUI();
        }

        void UpdateMovingFloor2()
        {
            int y = panelElevator2.Top;

            if (y >= floor2Y + 30)
                currentFloor2 = 1;
            else if (y >= floor3Y + 30)
                currentFloor2 = 2;
            else
                currentFloor2 = 3;

            UpdateUI();
        }


        void CallFloor(int floor)
        {
            if (IsOverLoaded())
            {
                lblOverload.Text = "OVERLOAD!";
                lblOverload.ForeColor = Color.Red;
                return;
            }

            if (doorOpen) return;
            if (floor == currentFloor) return;

            targetFloor = floor;

            if (targetFloor > currentFloor)
                currentState = ElevatorState.MovingUp;
            else
                currentState = ElevatorState.MovingDown;

            timerElevator.Start();
            UpdateUI();
        }

        void CallNearestElevator(int floor)
        {
            int d1 = Math.Abs(floor - currentFloor);
            int d2 = Math.Abs(floor - currentFloor2);

            if (d1 <= d2)
                MoveElevator1(floor);
            else
                MoveElevator2(floor);
        }


        void OpenDoor()
        {
            if (doorOpen) return;
            currentState = ElevatorState.DoorOpen;
            doorOpen = true;

            panelDoorLeft.Left -= 30;
            panelDoorRight.Left += 30;

            UpdateUI();
        }

        void CloseDoor()
        {
            currentState = ElevatorState.DoorClosed;
            doorOpen = false;

            panelDoorLeft.Left += 30;
            panelDoorRight.Left -= 30;

            currentState = ElevatorState.Idle;
            UpdateUI();
        }

        void OpenDoor2()
        {
            if (doorOpen2) return;

            doorOpen2 = true;
            currentState2 = ElevatorState.DoorOpen;

            panelDoorLeft2.Left -= 30;
            panelDoorRight2.Left += 30;

            UpdateUI();
        }

        void CloseDoor2()
        {
            if (!doorOpen2) return;

            doorOpen2 = false;
            currentState2 = ElevatorState.Idle;

            panelDoorLeft2.Left += 30;
            panelDoorRight2.Left -= 30;

            UpdateUI();
        }

        int GetFloorY(int floor)
        {
            if (floor == 1) return floor1Y;
            if (floor == 2) return floor2Y;
            return floor3Y;
        }

        void UpdateUI()
        {
            if (numWeight.Value <= 500)
                lblOverload.Text = "";

            lblFloor.Text = "Floor: " + currentFloor;
            lblStatus.Text = "Status: " + currentState;
            lblDoor.Text = "Door: " + (doorOpen ? "Open" : "Closed");

            // Elevator 2
            lblFloor2.Text = "Floor: " + currentFloor2;
            lblStatus2.Text = "Status: " + currentState2;
            lblDoor2.Text = "Door: " + (doorOpen2 ? "Open" : "Closed");
        }

        private void panelElevator2_Paint(object sender, PaintEventArgs e)
        {

        }


        void MoveElevator1(int floor)
        {
            if (IsOverLoaded()) return;
            
            if (doorOpen)
                CloseDoor(); 
                
            targetFloor = floor;

            if (targetFloor > currentFloor)
                currentState = ElevatorState.MovingUp;
            else
                currentState = ElevatorState.MovingDown;

            timerElevator.Start();
            UpdateUI();
        }

        void MoveElevator2(int floor)
        {
            if (doorOpen)
               CloseDoor();
            
            targetFloor2 = floor;

            if (targetFloor2 > currentFloor2)
                currentState2 = ElevatorState.MovingUp;
            else if (targetFloor2 < currentFloor2)
                currentState2 = ElevatorState.MovingDown;

            timerElevator2.Start();
            UpdateUI();
        }

        bool IsOverLoaded()
        {
            return numWeight.Value > 500;
        }

        private void timerElevator2_Tick(object sender, EventArgs e)
        {
            int targetY = GetFloorY(targetFloor2);

            if (panelElevator2.Top < targetY)
            {
                panelElevator2.Top += 2;
                UpdateMovingFloor2();
            }
            else if (panelElevator2.Top > targetY)
            {
                panelElevator2.Top -= 2;
                UpdateMovingFloor2();
            }

        }

        private void btnDoor2_Click(object sender, EventArgs e)
        {
            if (!doorOpen2)
                OpenDoor2();
            else
                CloseDoor2();
        }

        private void btn2Floor_Click(object sender, EventArgs e)
        {
            MoveElevator2(2);
        }

        private void btn1Floor_Click(object sender, EventArgs e)
        {
            MoveElevator2(1);
        }

        private void btn3Floor_Click(object sender, EventArgs e)
        {
            MoveElevator2(3);
        }
    }
}
    

