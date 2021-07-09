# This sheet is to provide a set of instructions to keep for further use.

//SETUP//
1.  Load script into Programmable Block.
2.  Selct any block to add your code to
3.  Set up of a codeblock looks like this:
        @NAMEOFFUNCTION{
            Instructions go here
        }
4.  Call the function by adding the function to:
        a. Button
        b. Sensor
        c. Another Programmable Block
    On the selected Activator, selct the Programmable Block and Run function "Block(NAMEOFFUNCTION)".
5.  Bobs your uncle.

//STATEMENTS//
1.  Show Actions of...
2.  Show Properties of...
@My Block{
    Show Properties of MyPiston
}

//CREATING COLOURS//
255:0:0 is Bright Red
0:255:0 is Bright Green
0:0:255 is Bright Blue

//WRITING FUNCTIONS//
1.  Property
2.  "of"
3.  Name of Block/s
4.  Operator = < >
5.  Desired Value
    @MY BLOCK{
        Velocity of MYPISTON = 1.23
    }

//RENAMING FUNCTION//
1.  "=" will completely rename the block(s)     @My Block{Rename MyPiston = "YourPiston"}   "YourPiston"
2.  "+" will add to the end of the name of the block(s)     @My Block{Rename MyPiston + " YourPiston"}  "MyPiston YourPiston"
3.  "+" followed by a number will add to that position within the name of a block       @My Block{Rename Ror +1 "ot"}   "Rotor"
4.  "-" will remove all instances of the indicated set of characters from the name(s)   @My Block{Rename MyPiston - "Pist"} "Myon"

//GROUP FUNCTIONS//
Method 1.   Create a group and use @My Block{Velocity of (MYGROUP) = 1.23}  //Will control all blocks in group
Method 2.   Name blocks the same name or similar @My Block{Velocity of Piston = 1.23}   //Both functions will provide the same instance

//FUNCTIONS//
    //LCDS
    Write to #LCD = "will only write to LCD"  //adds the text to the public text of the LCD(s) and displays it
    Write to LCD = "will write to all LCD's"  //adds the text to the public text of the LCD(s) and displays it
    WriteLine to LCD = "adds line to text" //adds the text to the public text of the LCD(s) on a new line and displays it
    WriteNew to LCD = "writes over everything else" //Writes over everything currently on the public text of the LCD(s) and displays it
    Clear LCD   //Clears the public text of the LCD(s)
    CustomWrite to LCD = "" //adds the text to the Custom Data of the LCD(s) 
    CustomWriteLine to LCD = "" //adds the text to the Custom Data of the LCD(s) on a new line 
    CustomWriteNew to LCD = ""  //Writes over everything currently on the Custom Data of the LCD(s)
    Image of Test LCD = "Danger"  //displays the indicated texture to the indicated LCD(s)

    //LIGHTS
    onoff of Light = On

    //PISTONS
    Extend Piston
    Retract Piston

    //PROGRAMMABLE BLOCK
    Run Programming Block   //Runs Programming Block with no argument
    RunWithDefaultArgument  //Runs with the argument that is stored in each one's own "default argument" field
    Run Programming Block = This argument   //Runs with the argument "This Argument"

    //ROTORS
    Rotate Rotor to 30 at 10
    ShortRotate to 30 at 10     //finds the shortest route

//VARIABLES//
All variables are to be set in the Variables Function:
@Variables{MyVariable = 1.23}
@MyFunction{Velocity of Piston = MyVariable}
Number Variables - 

//LOGIC FUNCTIONS//
    //DELAY
    delay 1000  //delays by 1000 milliseconds

    //WHEN STATEMENTS
    when Target of Piston = 1   //then do next thing
        "="     //Continue when it equals "=" the proposed value from any one of the blocks in the group
        "!="    //Continue when it does NOT equal "!=" the proposed value from any one of the blocks in the group
        "<"     //Continue when it is less than "<" the largest value out of all the blocks in the group
                //This means it will only continue if the proposed value is less then ANY of the actual values of the blocks in the group
        "<<"    //Continue when it is less then "<<" the smallest value out of all the blocks in the group
                //This means it will only continue if the proposed value is less then ALL of the actual values of the blocks in the group
        ">"     //Continue when it is greater than ">" the smallest value out of all the blocks in the group
                //This means it will only continue if the proposed value is greater then ANY of the actual values of the blocks in the group
        ">>"    //Continue when it is greater than ">" the largest value out of all the blocks in the group
                //This means it will only continue if the proposed value is greater then ALL of the actual values of the blocks in the group
        True / On   
        False / Off

    //IF, ELSE IF, ELSE STATEMENTS
        if current angle of Rotor > 30 {extend Piston}
        if Door = open {Door close}
            Execute Statements in IfBlock if it equals "="
            Execute Statements in IfBlock if it does NOT equal "!="
            Execute Statements in IfBlock if it is less than ANY "<"
            Execute Statements in IfBlock if it is less than EVERY "<<"
            Execute Statements in IfBlock if it is greater than ANY ">"
            Execute Statements in IfBlock if it is greater than EVERY ">>"
        if current angle of Rotor > 30 {extend Piston} else {retract Piston}
        if current angle of Rotor > 100 {extend Piston} else if current angle of Rotor > 75 {retract Piston} else if current angle or Rotor > 50 {extend Piston}

    //REFERENCING OTHER CODE BLOCKS
    @MYCODE{@THISCODE @THATCODE}    //Runs other code blocks in your code block

    Air Vent
Interface name: IMyAirVent
Parent: IMyFunctionalBlock
Fields:
bool CanPressurize { get; }
bool Depressurize { get; set; }
bool IsDepressurizing { get; } Depreciated
bool PressurizationEnabled { get; }
enum VentStatus Status { get; }
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off ->Toggle Block Off
Depressurize -> Depressurize On/Off
Depressurize_On -> Depressurize On
Depressurize_Off -> Depressurize Off
Advanced Rotor
Interface name: IMyMotorAdvancedStator
Parent: IMyMotorBase
Parent: IMyFunctionalBlock
Fields:
float Angle { get; }
float BrakingTorque { get; set; }
float Displacement { get; set; }
float LowerLimitDeg { get; set; }
float LowerLimitRad { get; set; }
bool RotorLock { get; set; }
float TargetVelocityRad { get; set; }
float TargetVelocityRPM { get; set; }
float Torque { get; set; }
float UpperLimitDeg { get; set; }
float UpperLimitRad { get; set; }
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off ->Toggle Block Off
Reverse -> Reverse
Attach -> Attach
IncreaseTorque -> Increase Torque
DecreaseTorque -> Decrease Torque
IncreaseBrakingTorque -> Increase Braking Torque
DecreaseBrakingTorque -> Decrease Braking Torque
IncreaseVelocity -> Increase Velocity
ResetVelocity -> Reset Velocity
IncreaseLowerLimit -> Increase Lower Limit
DecreaseLowerLimit -> Decrease Lower Limit
IncreaseUpperLimit -> Increase Upper Limit
DecreaseUpperLimit -> Decrease Upper Limit
IncreaseDisplacement -> Increase Rotor Displacement
DecreaseDisplacement -> Decrease Rotor Displacement
Antenna
Interface name: IMyRadioAntenna
Parent: IMyFunctionalBlock
Fields:
long AttachedProgrammableBlock { get; set; }
bool EnableBroadcasting { get; set; }
bool IgnoreAlliedBroadcast { get; set; }
bool IgnoreOtherBroadcast { get; set; }
bool IsBroadcasting { get; }
float Radius { get; set; }
bool ShowShipName { get; set; }
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreaseRadius -> Increase Broadcast radius
DecreaseRadius -> Decrease Broadcast radius
EnableBroadCast -> Toggle Broadcast On/Off
ShowShipName -> Toggle Showing Ship Name

Artificial Mass
Interface name: IMyVirtualMass
Parent: IMyFunctionalBlock
Fields: none
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Assembler
Interface name: IMyAssembler
Parent: IMyProductionBlock
Parent: IMyFunctionalBlock
Fields:
bool CooperativeMode { get; set; }
float CurrentProgress { get; }
bool DisassembleEnabled { get; }
MyAssemblerMode Mode { get; set; }
bool Repeating { get; set; }
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off
slaveMode -> Cooperative Mode On/Off
Battery
Interface name: IMyBatteryBlock
Parent: IMyFunctionalBlock
Fields:
float CurrentInput { get; }
float CurrentOutput { get; }
float CurrentStoredPower { get; }
bool HasCapacityRemaining { get; }
bool IsCharging { get; }
float MaxInput { get; }
float MaxOutput { get; }
float MaxStoredPower { get; }
bool OnlyDischarge { get; set; }
bool OnlyRecharge { get; set; }
bool SemiautoEnabled { get; set; }
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Recharge -> Recharge On/Off
Discharge -> Discharge On/Off
SemiAuto -> Semi-auto On/Off
Beacon
Interface name: IMyBeacon
Parent: IMyFunctionalBlock
Fields:
float Radius { get; set; }
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreaseRadius -> Increase Broadcast radius
DecreaseRadius -> Decrease Broadcast radius
Button Panel
Interface name: IMyButtonPanel
Fields:
bool AnyoneCanUse { get; set; }

Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Camera
Interface name: IMyCameraBlock
Parent: IMyFunctionalBlock
Fields:
double AvailableScanRange { get; }
bool EnableRaycast { get; set; }
bool IsActive { get; }
float RaycastConeLimit { get; }
double RaycastDistanceLimit { get; }
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
View -> View
Cargo Containers
Interface name: IMyCargoContainer
Parent: IMyTerminalBlock
Fields: none
Actions: none
Cockpit, Control Station, Flight Seat
Interface name: IMyCockpit
Parent: IMyShipController
Fields:
bool ControlWheels
bool ControlThrusters
bool HandBrake
bool DampenersOverride
bool MainCockpit
bool HorizonIndicator
Actions:
ControlThrusters -> Control thrusters On/Off
ControlWheels -> Control wheels On/Off
HandBrake -> Handbrake On/Off
DampenersOverride -> Inertia dampeners On/Off
MainCockpit -> Main Cockpit On/Off
HorizonIndicator -> Show Horizon and Altitude On/Off
Collector
Interface name: IMyCollector
Parent: IMyFunctionalBlock
Fields:
bool UseConveyorSystem

Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off

Connector
Interface name: IMyShipConnector
Parent: IMyFunctionalBlock
Fields:
bool ThrowOut
bool CollectAll
bool IsLocked
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
ThrowOut -> Throw Out On/Off
CollectAll -> Collect All On/Off
SwitchLock -> Switch lock
Control Panel
Interface name: IMyControlPanel
Fields: none
Actions:none
Conveyor Sorter
Interface name: IMyConveyorSorter
Fields:
bool DrainAll
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
DrainAll -> Drain All On/Off
Door
Interface name: IMyDoor
Parent: IMyFunctionalBlock
Fields:
bool Open

Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Open -> Open/Close Door
Open_On -> Open Door
Open_Off -> Close Door
Drill
Interface name: IMyShipDrill
Parent: IMyFunctionalBlock
Fields:
bool UseConveyorSystem
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off
Gatling Gun
Interface name: IMySmallGatlingGun
Parent: IMyUserControllableGun
Parent: IMyFunctionalBlock
Fields:
bool Shoot
bool UseConveyor
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off
ShootOnce -> Shoots Once
Shoot -> Shoot On/Off
Shoot_On -> Shoot On
Shoot_Off-> Shoot Off
Gatling Turret
Interface name: IMyLargeGatlingTurret
Parent: IMyLargeConveyorTurretBase
Parent: IMyLargeTurretBase
Parent: IMyUserControllableGun
Parent: IMyFunctionalBlock
Fields:
bool UseConveyorSystem
bool CanControl
float Range bool Shoot
bool EnableIdleMovement
bool TargetMeteors
bool TargetMoving
bool TargetMissiles
bool TargetSmallShips
bool TargetLargeShips
bool TargetCharacters
bool TargetStations
bool TargetNeutrals
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Control -> Control
IncreaseRange -> Increase Radius
DecreaseRange -> Decrease Radius
UseConveyor -> Use Conveyor System On/Off
ShootOnce -> Shoot once
Shoot -> Shoot On/Off
Shoot_On -> Shoot On
Shoot_Off -> Shoot Off
IncreaseRange -> Increase Aiming Radius
DecreaseRange -> Decrease Aiming Radius
EnableIdleMovement -> Idle Movement On/Off
EnableIdleMovement_On -> Idle Movement On
EnableIdleMovement_Off -> Idle Movement Off
TargetMeteors -> Target meteors On/Off
TargetMeteors_On -> Target meteors On
TargetMeteors_Off -> Target meteors Off
TargetMoving -> Target moving On/Off
TargetMoving_On -> Target moving On
TargetMoving_Off -> Target moving Off
TargetMissiles -> Target missiles On/Off
TargetMissiles_On -> Target missiles On
TargetMissiles_Off -> Target missiles Off
TargetSmallShips -> Target small ships On/Off
TargetSmallShips_On -> Target small ships On
TargetSmallShips_Off -> Target small ships Off
TargetLargeShips -> Target large ship On/Off
TargetLargeShips_On -> Target large ship On
TargetLargeShips_Off -> Target large ship Off
TargetCharacters -> Target characters On/Off
TargetCharacters_On -> Target characters On
TargetCharacters_Off -> Target characters Off
TargetStations -> Target stations On/Off
TargetStations_On -> Target stations On
TargetStations_Off -> Target stations Off
TargetNeutrals -> Target neutrals On/Off
TargetNeutrals_On -> Target neutrals On
TargetNeutrals_Off -> Target neutrals Off
Gravity Generator
Interface name: IMyGravityGenerator
Parent: IMyGravityGeneratorBase
Parent: IMyFunctionalBlock
Fields:
float FieldWidth
float FieldHeight
float FieldDepth
float Gravity

Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreaseWidth -> Increase Field width
DecreaseWidth -> Decrease Field width
IncreaseHeight -> Increase Field height
DecreaseHeight -> Decrease Field height
IncreaseDepth -> Increase Field depth
DecreaseDepth -> Decrease Field depth
IncreaseGravity -> Increase Acceleration
DecreaseGravity -> Decrease Acceleration
Grinder
Interface name: IMyShipGrinder
Parent: IMyShipToolBase
Parent: IMyFunctionalBlock
Fields: none
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off
Gyroscope
Interface name: IMyGyro
Parent: IMyFunctionalBlock
Fields:
float GyroPower
bool GyroOverride
float Yaw
float Pitch
float Roll

Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreasePower -> Increase Power
DecreasePower -> Decrease Power
Override -> Override controls On/Off
IncreaseYaw -> Increase Yaw override
DecreaseYaw -> Decrease Yaw override
IncreasePitch -> Increase Pitch override
DecreasePitch -> Decrease Pitch override
IncreaseRoll -> Increase Roll override
DecreaseRoll -> Decrease Roll override

Interior Light
Interface name: IMyInteriorLight
Parent: IMyLightingBlock
Parent: IMyFunctionalBlock
Fields:
float BlinkIntervalSeconds { get; set; }
float BlinkLength { get; set; }
float BlinkOffset { get; set; }
Color Color { get; set; }
float Falloff { get; set; }
float Intensity { get; set; }
float Radius { get; set; }
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreaseRadius -> Increase Radius
DecreaseRadius -> Decrease Radius
IncreaseBlink Interval -> Increase Blink Interval
DecreaseBlink Interval -> Decrease Blink Interval
IncreaseBlink Lenght -> Increase Blink Length
DecreaseBlink Lenght -> Decrease Blink Length
IncreaseBlink Offset -> Increase Blink Offset
DecreaseBlink Offset -> Decrease Blink Offset

Interior Turret
Interface name: IMyLargeInteriorTurret
Parent: IMyLargeTurretBase
Parent: IMyUserControllableGun
Parent: IMyFunctionalBlock
Fields:
bool CanControl
float Range
bool Shoot
bool EnableIdleMovement
bool TargetMeteors
bool TargetMoving
bool TargetMissiles
bool TargetSmallShips
bool TargetLargeShips
bool TargetCharacters
bool TargetStations
bool TargetNeutrals
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Control -> Control
IncreaseRange -> Increase Radius
DecreaseRange -> Decrease Radius
ShootOnce -> Shoot once
Shoot -> Shoot On/Off
Shoot_On -> Shoot On
Shoot_Off -> Shoot Off
IncreaseRange -> Increase Aiming Radius
DecreaseRange -> Decrease Aiming Radius
EnableIdleMovement -> Idle Movement On/Off
EnableIdleMovement_On -> Idle Movement On
EnableIdleMovement_Off -> Idle Movement Off
TargetMeteors -> Target meteors On/Off
TargetMeteors_On -> Target meteors On
TargetMeteors_Off -> Target meteors Off
TargetMoving -> Target moving On/Off
TargetMoving_On -> Target moving On
TargetMoving_Off -> Target moving Off
TargetMissiles -> Target missiles On/Off
TargetMissiles_On -> Target missiles On
TargetMissiles_Off -> Target missiles Off
TargetSmallShips -> Target small ships On/Off
TargetSmallShips_On -> Target small ships On
TargetSmallShips_Off -> Target small ships Off
TargetLargeShips -> Target large ship On/Off
TargetLargeShips_On -> Target large ship On
TargetLargeShips_Off -> Target large ship Off
TargetCharacters -> Target characters On/Off
TargetCharacters_On -> Target characters On
TargetCharacters_Off -> Target characters Off
TargetStations -> Target stations On/Off
TargetStations_On -> Target stations On
TargetStations_Off -> Target stations Off
TargetNeutrals -> Target neutrals On/Off
TargetNeutrals_On -> Target neutrals On
TargetNeutrals_Off -> Target neutrals Off
Jump Drive
Interface name: IMyJumpDrive
Parent: IMyFunctionalBlock
Fields:
bool Recharge
bool JumpDistance
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Recharge -> Recharge On/Off
Recharge_On -> Recharge On
Recharge_Off -> Recharge Off
IncreaseJumpDistance -> Increase jump distance
DecreaseJumpDistance -> Decrease jump distance
Landing Gear
Interface name: IMyLandingGear
Parent: IMyFunctionalBlock
Fields:
bool Autolock
float BreakForce
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Lock -> Lock
Unlock -> Unlock
SwitchLock -> Switch lock
Autolock -> Autolock On/Off
IncreaseBreakForce -> Increase Break Force
DecreaseBreakForce -> Decrease Break Force
Laser Antenna
Interface name: IMyLaserAntenna
Parent: IMyFunctionalBlock
Fields:
bool isPerm
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Idle -> Idle
PasteGpsCoords -> Paste coordinates
ConnectGPS -> Connect to coordinates
isPerm -> Permanent connection On/Off
Medical Room
Interface name: IMyMedicalRoom
Parent: IMyFunctionalBlock
Fields:
bool TakeOwnership
bool SetFaction
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Merge Block
Interface name: IMyShipMergeBlock
Parent: IMyFunctionalBlock
Fields: none
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Missile Turret
Interface name: IMyMissileTurret
Parent: IMyLargeConveyorTurretBase
Parent: IMyLargeTurretBase
Parent: IMyUserControllableGun
Parent: IMyFunctionalBlock
Fields:
bool CanControl
float Range
bool Shoot
bool EnableIdleMovement
bool TargetMeteors
bool TargetMoving
bool TargetMissiles
bool TargetSmallShips
bool TargetLargeShips
bool TargetCharacters
bool TargetStations
bool TargetNeutrals
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Control -> Control
IncreaseRange -> Increase Radius
DecreaseRange -> Decrease Radius
ShootOnce -> Shoot once
Shoot -> Shoot On/Off
Shoot_On -> Shoot On
Shoot_Off -> Shoot Off
IncreaseRange -> Increase Aiming Radius
DecreaseRange -> Decrease Aiming Radius
UseConveyor -> Use Conveyor System On/Off
EnableIdleMovement -> Idle Movement On/Off
EnableIdleMovement_On -> Idle Movement On
EnableIdleMovement_Off -> Idle Movement Off
TargetMeteors -> Target meteors On/Off
TargetMeteors_On -> Target meteors On
TargetMeteors_Off -> Target meteors Off
TargetMoving -> Target moving On/Off
TargetMoving_On -> Target moving On
TargetMoving_Off -> Target moving Off
TargetMissiles -> Target missiles On/Off
TargetMissiles_On -> Target missiles On
TargetMissiles_Off -> Target missiles Off
TargetSmallShips -> Target small ships On/Off
TargetSmallShips_On -> Target small ships On
TargetSmallShips_Off -> Target small ships Off
TargetLargeShips -> Target large ship On/Off
TargetLargeShips_On -> Target large ship On
TargetLargeShips_Off -> Target large ship Off
TargetCharacters -> Target characters On/Off
TargetCharacters_On -> Target characters On
TargetCharacters_Off -> Target characters Off
TargetStations -> Target stations On/Off
TargetStations_On -> Target stations On
TargetStations_Off -> Target stations Off
TargetNeutrals -> Target neutrals On/Off
TargetNeutrals_On -> Target neutrals On
TargetNeutrals_Off -> Target neutrals Off
Ore Detector
Interface name: IMyOreDetector
Parent: IMyFunctionalBlock
Fields:
bool BroadcastUsingAntennas
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
BroadcastUsingAntennas -> Broadcast using antennas On/Off
Oxygen Farm
Interface name: IMyOxygenFarm
Parent: IMyFunctionalBlock
Fields: none
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Oxygen Generator
Interface name: IMyOxygenGenerator
Parent: IMyFunctionalBlock
Fields:
bool Auto-Refill
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Refill -> Refill Bottles
Auto-Refill -> Auto-Refill On/Off
Oxygen/Hydrogen Tank
Interface name: IMyOxygenTank
Parent: IMyFunctionalBlock
Fields:
bool Stockpile
bool Auto-Refill
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Stockpile -> Stockpile On/Off
Stockpile_On -> Stockpile On
Stockpile_Off -> Stockpile Off
Refill -> Refill Bottles
Auto-Refill -> Auto-Refill On/Off
Passenger Seat
Interface name: IMyCockpit
Parent: IMyShipController
Fields:
bool ControlWheels
bool ControlThrusters
bool HandBrake
bool DampenersOverride

Actions:
ControlThrusters -> Control thrusters On/Off
ControlWheels -> Control wheels On/Off
HandBrake -> Handbrake On/Off
DampenersOverride -> Inertia dampeners On/Off

Piston
Interface name: IMyPistonBase
Parent: IMyFunctionalBlock
Fields:
bool OnOff
bool ShowInTerminal
bool ShowInToolbarConfig
bool ShowOnHUD
float Velocity
float MinLimit "LowerLimit"
float MaxLimit "UpperLimit"
PistonStatus Status
float "Weld speed"
bool "Force weld"

Strings to be used in methods like "bool GetValueBool(string propertyId)"

Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Reverse -> Reverse
Extend -> Extend
Retract -> Retract
IncreaseVelocity -> Increase Velocity
DecreaseVelocity -> Decrease Velocity
ResetVelocity -> Reset Velocity
IncreaseUpperLimit -> Increase Maximal distance
DecreaseUpperLimit -> Decrease Maximal distance
IncreaseLowerLimit -> Increase Minimal distance
DecreaseLowerLimit -> Decrease Minimal distance
IncreaseWeld speed -> Increase Safety lock speed
DecreaseWeld speed -> Decrease Safety lock speed
IncreaseMaxImpulseAxis
DecreaseMaxImpulseAxis
IncreaseMaxImpulseNonAxis
DecreaseMaxImpulseNonAxis
Force weld -> Safety override lock On/Off
Force weld
IncreaseSafetyDetach
DecreaseSafetyDetach
ShareInertiaTensor
Add Top Part
Programmable block
Interface name: IMyProgrammableBlock
Parent: IMyFunctionalBlock
Fields:
bool IsRunning

Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Run -> Run
RunWithDefaultArgument -> Run with default argument
Projector
Interface name: IMyProjector
Parent: IMyFunctionalBlock
Fields:
bool OnOff
bool ShowInTerminal
bool ShowInToolbarConfig
bool ShowOnHUD
bool KeepProjection
bool ShowOnlyBuildable
float X
float Y
float Z
float RotX
float RotY
float RotZ
bool InstantBuilding
bool GetOwnership
float NumberOfProjections
float NumberOfBlocks
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
KeepProjection -> Keep Projection On/Off
IncreaseX -> Increase horizontal offset
DecreaseX -> Decrease horizontal offset
IncreaseY -> Increase vertical offset
DecreaseY -> Decrease vertical offset
IncreaseZ -> Increase forward offset
DecreaseZ -> Decrease forward offset
IncreaseRotX -> Increase Pitch
DecreaseRotX -> Decrease Pitch
IncreaseRotY -> Increase Yaw
DecreaseRotY -> Decrease Yaw
IncreaseRotZ -> Increase Roll
DecreaseRotZ -> Decrease Roll
IncreaseScale
DecreaseScale
SpawnProjection -> Spawn projection
IncreaseFontSize
DecreaseFontSize
IncreaseTextPaddingSlider
DecreaseTextPaddingSlider
IncreaseChangeIntervalSlider
DecreaseChangeIntervalSlider
PreserveAspectRatio
Reactor (Small, Large)
Interface name: IMyReactor
Parent: IMyFunctionalBlock
Fields:
bool UseConveyorSystem
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off

Refinery and Arc Furnace
Interface name: IMyRefinery
Parent: IMyProductionBlock
Parent: IMyFunctionalBlock
Fields:
bool UseConveyorSystem
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off
Reloadable Rocket Launcher
Interface name: IMySmallMissileLauncherReload
Parent: IMySmallMissileLauncherReload
Parent: IMySmallMissileLauncher
Parent: IMyUserControllableGun
Parent: IMyFunctionalBlock
Fields:
bool Shoot
Actions:
Off -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off
ShootOnce -> Shoot once
Shoot -> Shoot On/Off
Shoot_On -> Shoot On
Shoot_Off -> Shoot Off
Remote Control
Interface name: IMyRemoteControl
Parent: IMyShipController
Fields:
bool ControlThrusters
bool ControlWheels
bool HandBrake
bool DampenersOverride
bool MainCockpit
bool HorizonIndicator
bool AutoPilot
bool CollisionAvoidance
bool DockingMode
Actions:
ControlThrusters -> Control thrusters On/Off
ControlWheels -> Control wheels On/Off
HandBrake -> Handbrake On/Off
DampenersOverride -> Inertia dampeners On/Off
MainCockpit -> Main cockpit On/Off
AutoPilot -> Autopilot On/Off
AutoPilot_On -> Autopilot On
AutoPilot_Off -> Autopilot Off
CollisionAvoidance -> Collision avoidance On/Off
CollisionAvoidance_On -> Collision avoidance On
CollisionAvoicance_Off -> Collision avoidance Off
DockingMode -> Precision mode On/Off
DockingMode_On -> Precision mode On
DockingMode_Off -> Precision mode Off
Forward -> Set front part of remote control as reference for autopilot
Backward -> Set rear part of remote control as reference for autopilot
Left -> Set left part of remote control as reference for autopilot
Right -> Set right part of remote control as reference for autopilot
Up -> Set top part of remote control as reference for autopilot
Down -> Set bottom part of remote control as reference for autopilot
Rocket Launcher
Interface name: IMySmallMissileLauncher
Parent: IMyUserControllableGun
Parent: IMyFunctionalBlock
Fields:
bool Shoot
s

Actions:
Off -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off
ShootOnce -> Shoot once
Shoot -> Shoot On/Off
Shoot_On -> Shoot On
Shoot_Off -> Shoot Off
Rotor
Interface name: IMyMotorStator
Parent: IMyMotorBase
Parent: IMyFunctionalBlock
Fields:
bool IsAttached
float Torque
float BrakingTorque
float Velocity
float LowerLimit
float UpperLimit
float Displacement

Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Reverse -> Reverse
Detach -> Detach
Attach -> Attach
IncreaseTorque -> Increase Torque
DecreaseTorque -> Decrease Torque
IncreaseBrakingTorque -> Increase Braking tor.
DecreaseBrakingTorque -> Decrease Braking tor.
IncreaseVelocity -> Increase Velocity
DecreaseVelocity -> Decrease Velocity
ResetVelocity -> Reset Velocity
IncreaseLowerLimit -> Increase Lower limit
DecreaseLowerLimit -> Decrease Lower limit
IncreaseUpperLimit -> Increase Upper limit
DecreaseUpperLimit -> Decrease Upper limit
IncreaseDisplacement -> Increase Rotor displacement
DecreaseDisplacement -> Decrease Rotor displacement

Sensor
Interface name: IMySensorBlock
Parent: IMyFunctionalBlock
Fields:
float LeftExtend
float RightExtend
float TopExtend
float BottomExtend
float FrontExtend
float BackExtend
bool DetectPlayers
bool DetectFloatingObjects
bool DetectSmallShips
bool DetectLargeShips
bool DetectStations
bool DetectAsteroids
bool IsActive
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreaseLeft -> Increase Left extent
DecreaseLeft -> Decrease Left extent
IncreaseRight -> Increase Right extent
DecreaseRight -> Decrease Right extent
IncreaseBottom -> Increase Bottom extent
DecreaseBottom -> Decrease Bottom extent
IncreaseTop -> Increase Top extent
DecreaseTop -> Decrease Top extent
IncreaseBack -> Increase Back extent
DecreaseBack -> Decrease Back extent
IncreaseFront -> Increase Front extent
DecreaseFront -> Decrease Front extent
Detect Players -> Detect players On/Off
Detect Floating Objects -> Detect floating objects On/Off
Detect Small Ships -> Detect small ships On/Off
Detect Large Ships -> Detect large ships On/Off
Detect Stations -> Detect stations On/Off
Detect Asteroids -> Detect Asteroids On/Off
Solar Panel
Interface name: IMySolarPanel
Fields: none
Actions: none
Sound Block
Interface name: IMySoundBlock
Parent: IMyFunctionalBlock
Fields:
float Volume
float Range
bool IsSoundSelected
float LoopPeriod

Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreaseVolumeSlider -> Increase Volume
DecreaseVolumeSlider -> Decrease Volume
IncreaseRangeSlider -> Increase Range
DecreaseRangeSlider -> Decrease Range
PlaySound -> Play
StopSound -> Stop
IncreaseLoopableSlider -> Increase Loop time
DecreaseLoopableSlider -> Decrease Loop time

Space Balls
Interface name: IMySpaceball
Parent: IMyVirtualMass
Parent: IMyFunctionalBlock
Fields:
float VirtualMass
bool EnableBroadCast
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreaseVirtualMass -> Increase Virtual Mass
DecreaseVirtualMass -> Decrease Virtual Mass
EnableBroadCast -> Enable broadcasting On/Off
Spherical Gravity Generator
Interface name: IMyGravityGeneratorSphere
Parent: IMyGravityGeneratorBase
Parent: IMyFunctionalBlock
Fields:
float Radius
float Gravity
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreaseRadius -> Increase Radius
DecreaseRadius -> Decrease Radius
IncreaseGravity -> Increase Acceleration
DecreaseGravity -> Decrease Acceleration
Spotlight
Interface name: IMyReflectorLight
Parent: IMyLightingBlock
Parent: IMyFunctionalBlock
Fields:
float Radius
float Intensity
float BlinkIntervalSeconds
float BlinkLenght
float BlinkOffset

Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreaseRadius -> Increase Radius
DecreaseRadius -> Decrease Radius
IncreaseBlink Interval -> Increase Blink Interval
DecreaseBlink Interval -> Decrease Blink Interval
IncreaseBlink Lenght -> Increase Blink Length
DecreaseBlink Lenght -> Decrease Blink Length
IncreaseBlink Offset -> Increase Blink Offset
DecreaseBlink Offset -> Decrease Blink Offset
Text Panel, LCD, Wide LCD
Interface name: IMyTextPanel
Parent: IMyFunctionalBlock
Fields:
float FontSize
String FontColor
String BackgroundColor
float ChangeIntervalSlider
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreaseFontSize -> Increase Font Size
DecreaseFontSize -> Decrease Font Size
IncreaseChangeIntervalSlider -> Increase Image change interval
DecreaseChangeIntervalSlider -> Decrease Image change interval
Thruster (Ion, Hydrogen, Atmospheric)
Interface name: IMyThrust
Parent: IMyFunctionalBlock
Fields:
float Override
Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreaseOverride -> Increase thrust override
DecreaseOverride -> Decrease thrust override
Timer Block
Interface name: IMyTimerBlock
Parent: IMyFunctionalBlock
Fields:
bool IsCountingDown
float TriggerDelay

Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreaseTriggerDelay -> Increase Delay
DecreaseTriggerDelay -> Decrease Delay
TriggerNow -> Trigger now
Start -> Start
Stop -> Stop
Warhead
Interface name: IMyWarhead
Fields:
bool IsCountingDown
float DetonationTime

Actions:
IncreaseDetonationTime -> Increase Detonation time
DecreaseDetonationTime -> Decrease Detonation time
StartCountdown -> Start countdown
StopCountdown -> Stop countdown
Safety -> Safety On/Off
Detonate -> Detonate

Welder
Interface name: IMyShipWelder
Parent: IMyShipToolBase
Parent: IMyFunctionalBlock

Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off

Wheel Suspension (1x1, 3x3, 5x5)
Interface name: IMyMotorSuspension
Parent: IMyMotorBase
Parent: IMyFunctionalBlock
Fields:
bool Steering
bool Propulsion
float Damping
float Strength
float Friction
float Power

Actions:
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Steering -> Steering On/Off
Propulsion -> Propulsion On/Off
IncreaseDamping -> Increase Damping
DecreaseDamping -> Decrease Damping
IncreaseStrength -> Increase Strength
DecreaseStrength -> Decrease Strength
IncreaseFriction -> Increase Friction
DecreaseFriction -> Decrease Friction
IncreasePower -> Increase Power
DecreasePower -> Decrease Power


