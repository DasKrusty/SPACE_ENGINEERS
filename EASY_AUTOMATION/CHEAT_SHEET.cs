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
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off ->Toggle Block Off
Depressurize -> Depressurize On/Off
Depressurize_On -> Depressurize On
Depressurize_Off -> Depressurize Off

Advanced Rotor
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
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreaseRadius -> Increase Broadcast radius
DecreaseRadius -> Decrease Broadcast radius
EnableBroadCast -> Toggle Broadcast On/Off
ShowShipName -> Toggle Showing Ship Name

Artificial Mass
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off

Assembler
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off
slaveMode -> Cooperative Mode On/Off

Battery
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Recharge -> Recharge On/Off
Discharge -> Discharge On/Off
SemiAuto -> Semi-auto On/Off

Beacon
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreaseRadius -> Increase Broadcast radius
DecreaseRadius -> Decrease Broadcast radius

Button Panel
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off

Camera
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
View -> View

Cockpit, Control Station, Flight Seat
ControlThrusters -> Control thrusters On/Off
ControlWheels -> Control wheels On/Off
HandBrake -> Handbrake On/Off
DampenersOverride -> Inertia dampeners On/Off
MainCockpit -> Main Cockpit On/Off
HorizonIndicator -> Show Horizon and Altitude On/Off

Collector
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off

Connector
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
ThrowOut -> Throw Out On/Off
CollectAll -> Collect All On/Off
SwitchLock -> Switch lock

Conveyor Sorter
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
DrainAll -> Drain All On/Off

Door
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Open -> Open/Close Door
Open_On -> Open Door
Open_Off -> Close Door

Drill
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off

Gatling Gun
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off
ShootOnce -> Shoots Once
Shoot -> Shoot On/Off
Shoot_On -> Shoot On
Shoot_Off-> Shoot Off

Gatling Turret
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
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off

Gyroscope
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
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Recharge -> Recharge On/Off
Recharge_On -> Recharge On
Recharge_Off -> Recharge Off
IncreaseJumpDistance -> Increase jump distance
DecreaseJumpDistance -> Decrease jump distance

Landing Gear
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
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Idle -> Idle
PasteGpsCoords -> Paste coordinates
ConnectGPS -> Connect to coordinates
isPerm -> Permanent connection On/Off

Medical Room
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off

Merge Block
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off

Missile Turret
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
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
BroadcastUsingAntennas -> Broadcast using antennas On/Off

Oxygen Farm
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off

Oxygen Generator
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Refill -> Refill Bottles
Auto-Refill -> Auto-Refill On/Off

Oxygen/Hydrogen Tank
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Stockpile -> Stockpile On/Off
Stockpile_On -> Stockpile On
Stockpile_Off -> Stockpile Off
Refill -> Refill Bottles
Auto-Refill -> Auto-Refill On/Off

Passenger Seat
ControlThrusters -> Control thrusters On/Off
ControlWheels -> Control wheels On/Off
HandBrake -> Handbrake On/Off
DampenersOverride -> Inertia dampeners On/Off

Piston
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
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
Run -> Run
RunWithDefaultArgument -> Run with default argument

Projector
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
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off

Refinery and Arc Furnace
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off

Reloadable Rocket Launcher
Off -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off
ShootOnce -> Shoot once
Shoot -> Shoot On/Off
Shoot_On -> Shoot On
Shoot_Off -> Shoot Off

Remote Control
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
Off -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off
ShootOnce -> Shoot once
Shoot -> Shoot On/Off
Shoot_On -> Shoot On
Shoot_Off -> Shoot Off

Rotor
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

Sound Block
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
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreaseVirtualMass -> Increase Virtual Mass
DecreaseVirtualMass -> Decrease Virtual Mass
EnableBroadCast -> Enable broadcasting On/Off

Spherical Gravity Generator
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreaseRadius -> Increase Radius
DecreaseRadius -> Decrease Radius
IncreaseGravity -> Increase Acceleration
DecreaseGravity -> Decrease Acceleration

Spotlight
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
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreaseFontSize -> Increase Font Size
DecreaseFontSize -> Decrease Font Size
IncreaseChangeIntervalSlider -> Increase Image change interval
DecreaseChangeIntervalSlider -> Decrease Image change interval

Thruster (Ion, Hydrogen, Atmospheric)
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreaseOverride -> Increase thrust override
DecreaseOverride -> Decrease thrust override

Timer Block
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
IncreaseTriggerDelay -> Increase Delay
DecreaseTriggerDelay -> Decrease Delay
TriggerNow -> Trigger now
Start -> Start
Stop -> Stop

Warhead
IncreaseDetonationTime -> Increase Detonation time
DecreaseDetonationTime -> Decrease Detonation time
StartCountdown -> Start countdown
StopCountdown -> Stop countdown
Safety -> Safety On/Off
Detonate -> Detonate

Welder
OnOff -> Toggle block On/Off
OnOff_On -> Toggle block On
OnOff_Off -> Toggle block Off
UseConveyor -> Use Conveyor System On/Off

Wheel Suspension (1x1, 3x3, 5x5)
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


