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

        int doorLeftClosedX;
        int doorRightClosedX;

        int doorLeft2ClosedX;
        int doorRight2ClosedX;
        int userFloor = 1;

        const int ARRIVAL_TOLERANCE = 2;

        public Form1()
        {
            InitializeComponent();

            doorLeftClosedX = panelDoorLeft.Left;
            doorRightClosedX = panelDoorRight.Left;

            doorLeft2ClosedX = panelDoorLeft2.Left;
            doorRight2ClosedX = panelDoorRight2.Left;

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
            if (userFloor < 3)
                CallNearestElevator(userFloor + 1);

        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (userFloor > 1)
                CallNearestElevator(userFloor - 1);
        }

        private void btnFloor1_Click(object sender, EventArgs e)
        {
            userFloor = 1;
            CallNearestElevator(1);

        }

        private void btnFloor2_Click(object sender, EventArgs e)
        {
            userFloor = 2;
            CallNearestElevator(2);
        }

        private void btnFloor3_Click(object sender, EventArgs e)
        {
            userFloor = 3;
            CallNearestElevator(3);

        }

        private void btnDoor_Click(object sender, EventArgs e)
        {
            if (currentState == ElevatorState.MovingUp || currentState == ElevatorState.MovingDown)
                return; 

            if (!doorOpen)
                OpenDoor();
            else
                CloseDoor();
        }


        private void timerElevator_Tick(object sender, EventArgs e)
        {
            int targetY = GetFloorY(targetFloor);
            int diff = targetY - panelElevator.Top;

            if (Math.Abs(diff) <= ARRIVAL_TOLERANCE)
            {
                panelElevator.Top = targetY;   // snap exactly
                timerElevator.Stop();
                currentFloor = targetFloor;
                currentState = ElevatorState.Idle;
                UpdateUI();
                OpenDoor();
            }
            else if (diff > 0)
            {
                panelElevator.Top += 2;
                UpdateMovingFloor();
            }
            else
            {
                panelElevator.Top -= 2;
                UpdateMovingFloor();
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
                lblOverload.ForeColor = Color.Red; return;
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
            if (currentState == ElevatorState.MovingUp || currentState == ElevatorState.MovingDown)
                return;

            doorOpen = true;
            currentState = ElevatorState.DoorOpen;

            panelDoorLeft.Left = doorLeftClosedX - panelDoorLeft.Width;
            panelDoorRight.Left = doorRightClosedX + panelDoorRight.Width;

            UpdateUI();
        }

        void CloseDoor()
        {
            if (!doorOpen) return;

            doorOpen = false;
            currentState = ElevatorState.DoorClosed;

            panelDoorLeft.Left = doorLeftClosedX;
            panelDoorRight.Left = doorRightClosedX;

            currentState = ElevatorState.Idle;
            UpdateUI();
        }

        void OpenDoor2()
        {
            if (doorOpen2) return;
            if (currentState2 == ElevatorState.MovingUp || currentState2 == ElevatorState.MovingDown)
                return;

            doorOpen2 = true;
            currentState2 = ElevatorState.DoorOpen;

            panelDoorLeft2.Left = doorLeft2ClosedX - panelDoorLeft2.Width;
            panelDoorRight2.Left = doorRight2ClosedX + panelDoorRight2.Width;

            UpdateUI();
        }

        void CloseDoor2()
        {
            if (!doorOpen2) return;

            doorOpen2 = false;
            currentState2 = ElevatorState.DoorClosed;

            panelDoorLeft2.Left = doorLeft2ClosedX;
            panelDoorRight2.Left = doorRight2ClosedX;

            currentState2 = ElevatorState.Idle;
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
            if (floor == currentFloor) return;

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
            if (IsOverLoaded()) return;

            if (floor == currentFloor2) return;

            if (doorOpen2)
                CloseDoor2();

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
            int diff = targetY - panelElevator2.Top;

            if (Math.Abs(diff) <= ARRIVAL_TOLERANCE)
            {
                panelElevator2.Top = targetY;
                timerElevator2.Stop();
                currentFloor2 = targetFloor2;
                currentState2 = ElevatorState.Idle;
                UpdateUI();
                OpenDoor2();
            }
            else if (diff > 0)
            {
                panelElevator2.Top += 2;
                UpdateMovingFloor2();
            }
            else
            {
                panelElevator2.Top -= 2;
                UpdateMovingFloor2();
            }

        }

        private void btnDoor2_Click(object sender, EventArgs e)
        {
            if (currentState2 == ElevatorState.MovingUp || currentState2 == ElevatorState.MovingDown)
                return; 

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
    

