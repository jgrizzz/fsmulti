' Add these two statements to all SimConnect clients
Imports System.IO
Imports System.Media
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports Microsoft.FlightSimulator
Imports Microsoft.FlightSimulator.SimConnect
Public Class Main


    Dim fsx_simconnect As SimConnect

    ' User-defined win32 event
    Private Const WM_USER_SIMCONNECT As Integer = &H402

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        fsx_simconnect = Nothing
        ' SetButtons(True, True)
        'TurnOffButtons("ALL")


    End Sub

    Public Sub initDataRequest()
        Try
            ' Set up all the SimConnect related data definitions and event handlers

            ' listen to connect and quit msgs
            AddHandler fsx_simconnect.OnRecvOpen, New SimConnect.RecvOpenEventHandler(AddressOf fsx_simconnect_OnRecvOpen)
            AddHandler fsx_simconnect.OnRecvQuit, New SimConnect.RecvQuitEventHandler(AddressOf fsx_simconnect_OnRecvQuit)
            ' listen to exceptions
            AddHandler fsx_simconnect.OnRecvException, New SimConnect.RecvExceptionEventHandler(AddressOf fsx_simconnect_OnRecvException)

            ' define a data structure, note the last parameter, datumID must be different for each item
            'Aircraft

            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "Indicated Altitude", "feet", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.FLOAT64, 0, 1)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "AIRSPEED INDICATED", "Knots", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 2)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "HEADING INDICATOR", "degrees", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.FLOAT64, 0, 3)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "FUEL TOTAL QUANTITY", "gallons", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 4)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "COM ACTIVE FREQUENCY:1", "MHZ", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.FLOAT64, 0, 5)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "COM STANDBY FREQUENCY:1", "MHZ", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.FLOAT64, 0, 6)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "COM ACTIVE FREQUENCY:2", "MHZ", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.FLOAT64, 0, 7)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "COM STANDBY FREQUENCY:2", "MHZ", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.FLOAT64, 0, 8)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "NAV ACTIVE FREQUENCY:1", "MHZ", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.FLOAT64, 0, 9)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "NAV STANDBY FREQUENCY:1", "MHZ", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.FLOAT64, 0, 10)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "NAV ACTIVE FREQUENCY:2", "MHZ", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.FLOAT64, 0, 11)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "NAV STANDBY FREQUENCY:2", "MHZ", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.FLOAT64, 0, 12)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "TRANSPONDER CODE:1", "MHZ", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.FLOAT64, 0, 13)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "AUTOPILOT MASTER", "BOOL", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 14)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "NAV OBS:1", "DEGREES", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 15)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "AUTOPILOT AIRSPEED HOLD VAR", "KNOTS", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 16)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "AUTOPILOT HEADING LOCK DIR", "DEGREES", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.FLOAT64, 0, 17)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "AUTOPILOT ALTITUDE LOCK VAR", "FEET", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 18)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "AUTOPILOT VERTICAL HOLD VAR", "Feet/minute", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 19)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "AUTOPILOT FLIGHT DIRECTOR ACTIVE", "Bool", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 20)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "AUTOPILOT THROTTLE ARM", "Bool", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 21)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "AUTOPILOT AIRSPEED HOLD", "Bool", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 22)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "AUTOPILOT HEADING LOCK", "Bool", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 23)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "AUTOPILOT APPROACH HOLD", "Bool", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 24)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "AUTOPILOT NAV1 LOCK", "Bool", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 25)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "AUTOPILOT ALTITUDE LOCK", "Bool", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 26)

            'Audio Selections
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "COM TRANSMIT:1", "Bool", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 27)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "COM TRANSMIT:2", "Bool", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 28)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "COM RECIEVE ALL", "Bool", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 29)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "NAV SOUND:1", "Bool", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 30)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "NAV SOUND:2", "Bool", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 31)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "DME SOUND", "Bool", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 32)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "MARKER SOUND", "Bool", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 33)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "ADF SOUND:0", "Bool", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 34)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "KOHLSMAN SETTING HG", "inHG", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.FLOAT64, 0, 35)

            'Controls
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "FLAPS HANDLE PERCENT", "Percent Over 100", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.FLOAT64, 0, 36)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "GEAR POSITION", "Enum", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.FLOAT64, 0, 37)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "PLANE ALT ABOVE GROUND", "Feet", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 38)

            'Engine Information
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "NUMBER OF ENGINES", "Number", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 39)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "GENERAL ENG THROTTLE LEVER POSITION:1", "Percent", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.FLOAT64, 0, 40)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "GENERAL ENG THROTTLE LEVER POSITION:2", "Percent", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.FLOAT64, 0, 41)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "GENERAL ENG THROTTLE LEVER POSITION:3", "Percent", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.FLOAT64, 0, 42)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "GENERAL ENG THROTTLE LEVER POSITION:4", "Percent", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.FLOAT64, 0, 43)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "TURB ENG N1:1", "Percent", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.FLOAT64, 0, 44)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "TURB ENG N1:1", "Percent", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.FLOAT64, 0, 45)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "TURB ENG N1:1", "Percent", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.FLOAT64, 0, 46)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "TURB ENG N1:1", "Percent", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.FLOAT64, 0, 47)

            'Brakes
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "BRAKE PARKING INDICATOR", "Bool", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 48)

            'Yaw Damper
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "AUTOPILOT YAW DAMPER", "Bool", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 49)

            'Elevator Trim
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "ELEVATOR TRIM PCT", "Percent over 100", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.FLOAT64, 0, 50)

            'Switches
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "LIGHT STROBE", "Bool", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 51)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "LIGHT LANDING", "Bool", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 52)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "LIGHT NAV", "Bool", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 53)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "LIGHT TAXI", "Bool", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 54)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "LIGHT PANEL", "Bool", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 55)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "LIGHT WING", "Bool", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 56)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "LIGHT CABIN", "Bool", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 57)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "LIGHT LOGO", "Bool", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 58)

            'GPS Information

            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "AI TRAFFIC ETA", "Seconds", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 59)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "FUEL TOTAL CAPACITY", "gallons", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.INT32, 0, 60)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "PLANE LATITUDE", "Radians", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.FLOAT64, 0, 61)
            fsx_simconnect.AddToDataDefinition(StructDefinitions.Aircraft, "PLANE LONGITUDE", "Radians", Microsoft.FlightSimulator.SimConnect.SIMCONNECT_DATATYPE.FLOAT64, 0, 62)


            'Auto Pilot Master Toggle
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_AP_Toggle, "AP_MASTER")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_AP_Toggle, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_AP_Toggle, "AP_MASTER")

            'Setup Transponder
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_Transponder, "XPNDR_SET")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_Transponder, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_Transponder, "XPNDR_SET")

            'Setup COM1
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_COM1_Stndby, "COM_STBY_RADIO_SET")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_COM1_Stndby, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_COM1_Stndby, "COM_STBY_RADIO_SET")

            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_COM1_Swap, "COM_STBY_RADIO_SWAP")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_COM1_Swap, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_COM1_Swap, "COM_STBY_RADIO_SWAP")

            'Setup COM2
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_COM2_Stndby, "COM2_STBY_RADIO_SET")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_COM2_Stndby, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_COM2_Stndby, "COM2_STBY_RADIO_SET")

            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_COM2_Swap, "COM2_RADIO_SWAP")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_COM2_Swap, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_COM2_Swap, "COM2_RADIO_SWAP")

            'Setup NAV1
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_NAV1_Stndby, "NAV1_STBY_SET")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_NAV1_Stndby, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_NAV1_Stndby, "NAV1_STBY_SET")

            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_NAV1_Swap, "NAV1_RADIO_SWAP")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_NAV1_Swap, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_NAV1_Swap, "NAV1_RADIO_SWAP")

            'Setup NAV2
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_NAV2_Stndby, "NAV2_STBY_SET")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_NAV2_Stndby, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_NAV2_Stndby, "NAV2_STBY_SET")

            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_NAV2_Swap, "NAV2_RADIO_SWAP")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_NAV2_Swap, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_NAV2_Swap, "NAV2_RADIO_SWAP")

            'Flight Director
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_FD_Toggle, "TOGGLE_FLIGHT_DIRECTOR")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_FD_Toggle, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_FD_Toggle, "TOGGLE_FLIGHT_DIRECTOR")

            'Auto Throttle ARM
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_THARM_Toggle, "AUTO_THROTTLE_ARM")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_THARM_Toggle, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_THARM_Toggle, "AUTO_THROTTLE_ARM")

            'Set Speed Hold Toggle
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_SPDHLD_Toggle, "AP_AIRSPEED_HOLD")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_SPDHLD_Toggle, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_SPDHLD_Toggle, "AP_AIRSPEED_HOLD")

            'Set Heading Hold Toggle
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_HDGHLD_Toggle, "AP_PANEL_HEADING_HOLD")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_HDGHLD_Toggle, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_HDGHLD_Toggle, "AP_PANEL_HEADING_HOLD")

            'Set Approach Hold Toggle
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_APPHLD_Toggle, "AP_APR_HOLD")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_APPHLD_Toggle, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_APPHLD_Toggle, "AP_APR_HOLD")

            'Set Yaw Damper Toggle
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_YAWD_Toggle, "YAW_DAMPER_TOGGLE")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_YAWD_Toggle, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_YAWD_Toggle, "YAW_DAMPER_TOGGLE")

            'Set LNAV Hold Toggle
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_LNAV_Toggle, "AP_NAV1_HOLD")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_LNAV_Toggle, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_LNAV_Toggle, "AP_NAV1_HOLD")

            'Set Speed
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_SPD_Set, "AP_SPD_VAR_SET")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_SPD_Set, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_SPD_Set, "AP_SPD_VAR_SET")

            'Set Heading
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_HDG_Set, "HEADING_BUG_SET")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_HDG_Set, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_HDG_Set, "HEADING_BUG_SET")

            ''Set OBS
            'fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_OBS_Set, "VOR1_SET")
            'fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_OBS_Set, True)
            'fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_OBS_Set, "VOR1_SET")

            'Set Altitude
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_ALT_Set, "AP_ALT_VAR_SET_ENGLISH")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_ALT_Set, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_ALT_Set, "AP_ALT_VAR_SET_ENGLISH")

            'Set Alt Hold Toggle
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_ALTHLD_Toggle, "AP_PANEL_ALTITUDE_HOLD")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_ALTHLD_Toggle, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_ALTHLD_Toggle, "AP_PANEL_ALTITUDE_HOLD")

            'Set VS
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_VS_Set, "AP_VS_VAR_SET_ENGLISH")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_VS_Set, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_VS_Set, "AP_VS_VAR_SET_ENGLISH")

            'Audio
            'Set CM1
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_CM1_Set, "COM1_TRANSMIT_SELECT")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_CM1_Set, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_CM1_Set, "COM1_TRANSMIT_SELECT")
            'Set CM2
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_CM2_Set, "COM2_TRANSMIT_SELECT")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_CM2_Set, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_CM2_Set, "COM2_TRANSMIT_SELECT")
            'Set BTH
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_BTH_Set, "COM_RECEIVE_ALL_TOGGLE")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_BTH_Set, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_BTH_Set, "COM_RECEIVE_ALL_TOGGLE")
            'Set NV1
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_NV1_Set, "RADIO_VOR1_IDENT_TOGGLE")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_NV1_Set, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_NV1_Set, "RADIO_VOR1_IDENT_TOGGLE")
            'Set NV2
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_NV2_Set, "RADIO_VOR2_IDENT_TOGGLE")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_NV2_Set, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_NV2_Set, "RADIO_VOR2_IDENT_TOGGLE")
            'Set DME
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_DME_Set, "RADIO_DME1_IDENT_TOGGLE")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_DME_Set, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_DME_Set, "RADIO_DME1_IDENT_TOGGLE")
            'Set MKR
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_MKR_Set, "MARKER_SOUND_TOGGLE")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_MKR_Set, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_MKR_Set, "MARKER_SOUND_TOGGLE")
            'Set ADF
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_ADF_Set, "RADIO_ADF_IDENT_TOGGLE")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_ADF_Set, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_ADF_Set, "RADIO_ADF_IDENT_TOGGLE")

            'Set Flaps
            'UP
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_FlapsUp, "FLAPS_DECR")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_FlapsUp, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_FlapsUp, "FLAPS_DECR")
            'Down
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_FlapsDown, "FLAPS_INCR")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_FlapsDown, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_FlapsDown, "FLAPS_INCR")

            'Set Gear
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_GearSet, "GEAR_SET")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_GearSet, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_GearSet, "GEAR_SET")

            'Set Barometer
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_Barometer, "BAROMETRIC")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_Barometer, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_Barometer, "BAROMETRIC")

            'Set ATC
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_ATC, "ATC")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_ATC, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_ATC, "ATC")
            'Set ATC1
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_ATC1, "ATC_MENU_1")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_ATC1, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_ATC1, "ATC_MENU_1")
            'Set ATC2
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_ATC2, "ATC_MENU_2")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_ATC2, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_ATC2, "ATC_MENU_2")
            'Set ATC3
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_ATC3, "ATC_MENU_3")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_ATC3, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_ATC3, "ATC_MENU_3")
            'Set ATC4
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_ATC4, "ATC_MENU_4")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_ATC4, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_ATC4, "ATC_MENU_4")
            'Set ATC5
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_ATC5, "ATC_MENU_5")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_ATC5, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_ATC5, "ATC_MENU_5")
            'Set ATC6
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_ATC6, "ATC_MENU_6")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_ATC6, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_ATC6, "ATC_MENU_6")
            'Set ATC7
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_ATC7, "ATC_MENU_7")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_ATC7, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_ATC7, "ATC_MENU_7")
            'Set ATC8
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_ATC8, "ATC_MENU_8")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_ATC8, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_ATC8, "ATC_MENU_8")
            'Set ATC9
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_ATC9, "ATC_MENU_9")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_ATC9, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_ATC9, "ATC_MENU_9")
            'Set ATC 10
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_ATC10, "ATC_MENU_10")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_ATC10, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_ATC10, "ATC_MENU_10")

            'Set VS Decremenmt
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_VSDec, "AP_VS_VAR_DEC")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_VSDec, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_VSDec, "AP_VS_VAR_DEC")

            'Set VS Increment
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_VSInc, "AP_VS_VAR_INC")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_VSInc, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_VSInc, "AP_VS_VAR_INC")

            'Set VS HOLD
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_VSInc, "AP_VS_VAR_INC")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_VSInc, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_VSInc, "AP_VS_VAR_INC")

            'Throttle Full
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Engine_Throttle_Full, "THROTTLE_FULL")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Engine_Throttle_Full, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Engine_Throttle_Full, "THROTTLE_FULL")

            'Throttle Idle
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Engine_Throttle_Cut, "THROTTLE_CUT")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Engine_Throttle_Cut, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Engine_Throttle_Cut, "THROTTLE_CUT")

            'Throttle Increment
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Engine_Throttle_Inc, "THROTTLE_INCR")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Engine_Throttle_Inc, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Engine_Throttle_Inc, "THROTTLE_INCR")

            'Throttle Decrement
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Engine_Throttle_Dec, "THROTTLE_DECR")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Engine_Throttle_Dec, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Engine_Throttle_Dec, "THROTTLE_DECR")

            'Throttle 10%
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Engine_Throttle_10, "THROTTLE_10")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Engine_Throttle_10, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Engine_Throttle_10, "THROTTLE_10")

            'Throttle 20%
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Engine_Throttle_20, "THROTTLE_20")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Engine_Throttle_20, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Engine_Throttle_20, "THROTTLE_20")

            'Throttle 30%
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Engine_Throttle_30, "THROTTLE_30")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Engine_Throttle_30, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Engine_Throttle_30, "THROTTLE_30")

            'Throttle 40%
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Engine_Throttle_40, "THROTTLE_40")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Engine_Throttle_40, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Engine_Throttle_40, "THROTTLE_40")

            'Throttle 50%
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Engine_Throttle_50, "THROTTLE_50")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Engine_Throttle_50, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Engine_Throttle_50, "THROTTLE_50")

            'Throttle 60%
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Engine_Throttle_60, "THROTTLE_60")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Engine_Throttle_60, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Engine_Throttle_60, "THROTTLE_60")

            'Throttle 70%
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Engine_Throttle_70, "THROTTLE_70")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Engine_Throttle_70, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Engine_Throttle_70, "THROTTLE_70")

            'Throttle 80%
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Engine_Throttle_80, "THROTTLE_80")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Engine_Throttle_80, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Engine_Throttle_80, "THROTTLE_80")

            'Throttle 90%
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Engine_Throttle_90, "THROTTLE_90")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Engine_Throttle_90, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Engine_Throttle_90, "THROTTLE_40")

            'Parking Brake Toggle
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Parkin_Brake, "PARKING_BRAKES")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Parkin_Brake, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Parkin_Brake, "PARKING_BRAKES")

            'Elevator Trim set
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_Trim_Up, "ELEV_TRIM_UP")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_Trim_Up, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_Trim_Up, "ELEV_TRIM_UP")

            ' 'Elevator Trim set
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_Trim_Down, "ELEVATOR_TRIM_DN")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_Trim_Down, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_Trim_Down, "ELEVATOR_TRIM_DN")

            'Strobe Lights
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_Strobe_Lights, "STROBES_TOGGLE")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_Strobe_Lights, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_Strobe_Lights, "STROBES_TOGGLE")

            'Landing Lights
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_Landing_Lights, "LANDING_LIGHTS_TOGGLE")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_Landing_Lights, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_Landing_Lights, "LANDING_LIGHTS_TOGGLE")

            'Nav Lights
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_Nav_Lights, "TOGGLE_NAV_LIGHTS")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_Nav_Lights, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_Nav_Lights, "TOGGLE_NAV_LIGHTS")

            'Taxi Lights
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_Taxi_Lights, "TOGGLE_TAXI_LIGHTS")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_Taxi_Lights, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_Taxi_Lights, "TOGGLE_TAXI_LIGHTS")

            'Panel Lights
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_Panel_Lights, "PANEL_LIGHTS_SET")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_Panel_Lights, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_Panel_Lights, "PANEL_LIGHTS_SET")

            'Wing Lights
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_Wing_Lights, "TOGGLE_WING_LIGHTS")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_Wing_Lights, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_Wing_Lights, "TOGGLE_WING_LIGHTS")

            'Cabin Lights
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_Cabin_Lights, "TOGGLE_CABIN_LIGHTS")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_Cabin_Lights, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_Cabin_Lights, "TOGGLE_CABIN_LIGHTS")

            'Logo Lights
            fsx_simconnect.MapClientEventToSimEvent(EVENT_ID.Avionics_Logo_Lights, "TOGGLE_LOGO_LIGHTS")
            fsx_simconnect.AddClientEventToNotificationGroup(Notification_group.Avionics_Group, EVENT_ID.Avionics_Logo_Lights, True)
            fsx_simconnect.SubscribeToSystemEvent(EVENT_ID.Avionics_Logo_Lights, "TOGGLE_LOGO_LIGHTS")

            ' IMPORTANT: register it with the simconnect managed wrapper marshaller
            ' if you skip this step, you will only receive an int in the .dwData field.
            fsx_simconnect.RegisterDataDefineStruct(Of Aircraft)(StructDefinitions.Aircraft)

            ' catch a simobject data request
            AddHandler fsx_simconnect.OnRecvSimobjectDataBytype, New SimConnect.RecvSimobjectDataBytypeEventHandler(AddressOf Fsx_simconnect_OnRecvSimobjectDataBytype)
        Catch ex As Exception
            LogError("InitDataRequest()", ex.Message)
        End Try


    End Sub

    Public Sub Fsx_simconnect_OnRecvSimobjectDataBytype(ByVal sender As SimConnect, ByVal data As SIMCONNECT_RECV_SIMOBJECT_DATA_BYTYPE)

        Try
            If Not fsx_simconnect Is Nothing Then
                Select Case data.dwRequestID
                    Case DataRequests.Request_1
                        ' Cast the data input to the correct structure type
                        Dim s1 As Aircraft = CType(data.dwData(0), Aircraft)
                        If s1.altitude < 1000 Then
                            ALTINFO = Math.Round(s1.altitude).ToString("00#")
                        Else
                            ALTINFO = Math.Round(s1.altitude).ToString("#0 00#")
                        End If

                        IASINFO = s1.airspeed

                        If s1.GALT < 1000 Then
                            GALTINFO = Math.Round(s1.GALT).ToString("00#")
                        Else
                            GALTINFO = Math.Round(s1.GALT).ToString("#0 00#")
                        End If

                        HEADINFO = s1.HDG
                        BAROINFO = s1.Barom.ToString("00.00")
                        FUELINFO = s1.fuel
                        FUELCAPACITY = s1.FuelCapacity
                        PLANELAT = ((s1.PlaneLatitude) * 180) / 3.14159
                        PLANELON = ((s1.Planelongitude) * 180) / 3.14159

                End Select
            End If
        Catch ex As Exception
            LogError("Fsx_simconnect_OnRecvSimobjectDataBytype", ex.Message)
        End Try
    End Sub

    ' The case where the user closes FSX
    Public Sub fsx_simconnect_OnRecvQuit(ByVal sender As SimConnect, ByVal data As Microsoft.FlightSimulator.SimConnect.SIMCONNECT_RECV)

        Try

            closeConnection()

        Catch ex As Exception
            LogError("fsx_simconnect_OnRecvQui", ex.Message)
        End Try
    End Sub

    Public Sub Main_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles MyBase.FormClosed

        closeConnection()

    End Sub

    Public Sub fsx_simconnect_OnRecvOpen(ByVal sender As SimConnect, ByVal data As SIMCONNECT_RECV_OPEN)
        Dim img As Stream
        img = DisplayImage("On_Side")
        ' btnConnect.BackgroundImage = New Bitmap(img).GetThumbnailImage(100, 35, Nothing, IntPtr.Zero)
        'lblmsg.Text = "Connected to Flight Simulator"
        btnPower.ForeColor = Color.Green
        PlaySound("Chime")
    End Sub

    Public Sub fsx_simconnect_OnRecvException(ByVal sender As SimConnect, ByVal data As Microsoft.FlightSimulator.SimConnect.SIMCONNECT_RECV_EXCEPTION)

        LogError("fsx_simconnect_OnRecvException()", data.dwException.ToString())

    End Sub

    Public Sub closeConnection()
        Try
            If fsx_simconnect IsNot Nothing Then
                fsx_simconnect.Dispose()
                fsx_simconnect = Nothing
                'lblmsg.ForeColor = Color.Red
                'lblmsg.Text = "Connection closed"
            End If
        Catch ex As Exception
            LogError("closeConnection()", ex.Message)
        End Try


    End Sub

    ' Simconnect client will send a win32 message when there is
    ' a packet to process. ReceiveMessage must be called to
    ' trigger the events. This model keeps simconnect processing on the main thread.
    Protected Overrides Sub DefWndProc(ByRef m As Message)
        Try


            If m.Msg = WM_USER_SIMCONNECT Then

                If fsx_simconnect IsNot Nothing Then
                    fsx_simconnect.ReceiveMessage()

                End If
            Else
                MyBase.DefWndProc(m)
            End If
        Catch ex As Exception
            LogError("DefWndProc", ex.Message)
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not fsx_simconnect Is Nothing Then
            CheckMenu()
            fsx_simconnect.RequestDataOnSimObjectType(DataRequests.Request_1, StructDefinitions.Aircraft, 0, Microsoft.FlightSimulator.SimConnect.SIMCONNECT_SIMOBJECT_TYPE.USER)
        End If
    End Sub

    Private Sub btnPower_Click(sender As Object, e As EventArgs) Handles btnPower.Click

        If OnButton = 0 Then
            If fsx_simconnect Is Nothing Then

                Try

                    PlaySound("Click")
                    fsx_simconnect = New SimConnect("Connect to Simconnect", Me.Handle, WM_USER_SIMCONNECT, Nothing, 0)
                    initDataRequest()

                    'lblmsg.Text = "Connection request sent ..."

                    Timer1.Enabled = True
                    OnButton = 1
                    btnPower.ForeColor = Color.LimeGreen
                Catch ex As Exception
                    'lblmsg.Text = "Failed to connect"
                    btnPower.ForeColor = Color.Red
                End Try
            Else
                'lblmsg.Text = "Error - try again"
                btnPower.ForeColor = Color.Red
                closeConnection()
            End If

        ElseIf OnButton = 1 Then
            'Dim img As Stream
            'img = DisplayImage("Off_Side")
            PlaySound("Click")
            btnPower.ForeColor = Color.Red
            'setButtons(True, False)
            Timer1.Enabled = False
            closeConnection()
            OnButton = 0

        End If

    End Sub

    Private Sub btnLightsPanel_Click(sender As Object, e As EventArgs) Handles btnSwitchesPanel.Click
        Switches.Visible = True
        btnSwitchesPanel.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub btnEinginesPanel_Click(sender As Object, e As EventArgs) Handles btnEinginesPanel.Click
        Engines.Visible = True
        btnEinginesPanel.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub btnRadiosPanel_Click(sender As Object, e As EventArgs) Handles btnRadiosPanel.Click
        Radios.Visible = True
        btnRadiosPanel.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub btnAutopilotPanel_Click(sender As Object, e As EventArgs) Handles btnAutopilotPanel.Click
        AutoPilot.Visible = True
    End Sub

    Private Sub btnSettingsPanel_Click(sender As Object, e As EventArgs) Handles btnSettingsPanel.Click
        Settings.Visible = True
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMonitorPanel_Click(sender As Object, e As EventArgs) Handles btnGaugesPanel.Click
        Gauges.Visible = True
        Monitor_Panel = True
        btnGaugesPanel.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub CheckMenu()
        If Monitor_Panel = False Then
            btnGaugesPanel.ForeColor = Color.White
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub
End Class
