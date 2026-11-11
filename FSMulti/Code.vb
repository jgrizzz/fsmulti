' Add these two statements to all SimConnect clients
Imports System.IO
Imports System.Media
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports Microsoft.FlightSimulator
Imports Microsoft.FlightSimulator.SimConnect

Module Code

    Public OnButton As Int16 = 0

    Public ALTINFO As String
    Public IASINFO As String
    Public GALTINFO As String
    Public HEADINFO As String
    Public BAROINFO As String
    Public FUELINFO As String
    Public FUELCAPACITY As String

    Public Monitor_Panel As Boolean
    Public AutoPilot_Panel As Boolean
    Public Radios_Panel As Boolean
    Public Switches_Panel As Boolean
    Public Engines_Panel As Boolean
    Public PLANELAT As Double
    Public PLANELON As Double


    Public Enum HSimconnect
        group1
    End Enum

    '****************************************
    Public Enum Definition
        Aircraft
        Enviroment
        AI
        Program

    End Enum

    Public Enum Notification_group
        Avionics_Group
        Engine_Group
        Controls_Group
        Switches_Group

    End Enum

    Public Enum EVENT_ID
        Avionics_AP_Toggle
        Avionics_COM1_Swap
        Avionics_COM1_Stndby
        Avionics_COM2_Swap
        Avionics_COM2_Stndby
        Avionics_NAV1_Swap
        Avionics_NAV1_Stndby
        Avionics_NAV2_Swap
        Avionics_NAV2_Stndby
        Avionics_Transponder
        Avionics_FD_Toggle
        Avionics_THARM_Toggle
        Avionics_SPDHLD_Toggle
        Avionics_HDGHLD_Toggle
        Avionics_APPHLD_Toggle
        Avionics_YAWD_Toggle
        Avionics_VNAV_Toggle
        Avionics_LNAV_Toggle
        Avionics_ALTHLD_Toggle
        Avionics_SPD_Set
        Avionics_HDG_Set
        Avionics_ALT_Set
        Avionics_VS_Set
        Avionics_CM1_Set
        Avionics_CM2_Set
        Avionics_BTH_Set
        Avionics_NV1_Set
        Avionics_NV2_Set
        Avionics_DME_Set
        Avionics_MKR_Set
        Avionics_ADF_Set
        Avionics_FlapsUp
        Avionics_FlapsDown
        Avionics_Trim_Up
        Avionics_Trim_Down
        Avionics_GearSet
        Avionics_Barometer
        Avionics_ATC
        Avionics_ATC1
        Avionics_ATC2
        Avionics_ATC3
        Avionics_ATC4
        Avionics_ATC5
        Avionics_ATC6
        Avionics_ATC7
        Avionics_ATC8
        Avionics_ATC9
        Avionics_ATC10
        Avionics_VSDec
        Avionics_VSInc
        Avionics_VSHold
        Engine_Throttle_Full
        Engine_Throttle_Cut
        Engine_Throttle_Inc
        Engine_Throttle_Dec
        Engine_Throttle_10
        Engine_Throttle_20
        Engine_Throttle_30
        Engine_Throttle_40
        Engine_Throttle_50
        Engine_Throttle_60
        Engine_Throttle_70
        Engine_Throttle_80
        Engine_Throttle_90
        Parkin_Brake
        Avionics_YawDamper
        Avionis_Elevator_Trim
        Avionics_Strobe_Lights
        Avionics_Landing_Lights
        Avionics_Nav_Lights
        Avionics_Taxi_Lights
        Avionics_Panel_Lights
        Avionics_Wing_Lights
        Avionics_Cabin_Lights
        Avionics_Logo_Lights

    End Enum

    ' This is how you declare a data structure so that simconnect knows how to fill it/read it.

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi, Pack:=1)>
    Structure Aircraft

        ' This is how you declare a fixed size string
        '<MarshalAs(UnmanagedType.ByValTStr, SizeConst:=256)>
        Public altitude As Double
        Public airspeed As Int32
        Public heading As Double
        Public fuel As Int32
        Public com1 As Double
        Public com1_standby As Double
        Public com2 As Double
        Public com2_standby As Double
        Public NAV1 As Double
        Public NAV1_standby As Double
        Public NAV2 As Double
        Public NAV2_standby As Double
        Public Xpdsr As Double
        Public APCmd As Int32
        Public OBS As Int32
        Public SPD As Int32
        Public HDG As Double
        Public ALT As Int32
        Public VS As Int32
        Public FD As Int32
        Public THARM As Int32
        Public SPDHLD As Int32
        Public HDGHLD As Int32
        Public APPHLD As Int32
        Public LNAVHLD As Int32
        Public ALTHLD As Int32
        Public COM1AUD As Int32
        Public COM2AUD As Int32
        Public COMBTH As Int32
        Public NAV1AUD As Int32
        Public NAV2AUD As Int32
        Public DMEAUD As Int32
        Public MKRAUD As Int32
        Public ADFAUD As Int32
        Public Barom As Double
        Public Flaps As Double
        Public Gear As Double
        Public GALT As Int32
        Public Engine_Num As Int32
        Public Engine_Thrust1 As Double
        Public Engine_Thrust2 As Double
        Public Engine_Thrust3 As Double
        Public Engine_Thrust4 As Double
        Public Engine1_TurbineN1 As Double
        Public Engine2_TurbineN1 As Double
        Public Engine3_TurbineN1 As Double
        Public Engine4_TurbineN1 As Double
        Public ParkingBrake As Boolean
        Public YAWDHLD As Int32
        Public Elevator_Trim As Double
        Public StrobeLights As Int32
        Public LandingLights As Int32
        Public NavLights As Int32
        Public TaxiLights As Int32
        Public PanelLights As Int32
        Public WingLights As Int32
        Public CabinLights As Int32
        Public LogoLights As Int32
        Public GPS_WP_ETA As Int32
        Public FuelCapacity As Int32
        Public PlaneLatitude As Double
        Public PlaneLongitude As Double



    End Structure






    Enum StructDefinitions

        Aircraft = 1

    End Enum

    Enum DataRequests
        Request_1 = 1

    End Enum

    Public Sub PlaySound(ByVal sound As String)
        Dim _audio As Stream
        Dim _assembly As [Assembly]
        _assembly = [Assembly].GetExecutingAssembly()

        Try
            Select Case sound
                Case "Chime"
                    _audio = _assembly.GetManifestResourceStream("FSXRemote.PMDG_737_HiLoChime.wav")
                    Dim playsnd As SoundPlayer = New SoundPlayer(_audio)
                    playsnd.Play()
                Case "Click"
                    _audio = _assembly.GetManifestResourceStream("FSXRemote.PMDG_737_APUSwitch_OnToOff.wav")
                    Dim playsnd As SoundPlayer = New SoundPlayer(_audio)
                    playsnd.Play()
                Case Else

            End Select
        Catch ex As Exception
            LogError("PlaySound()", ex.Message)
        End Try

    End Sub

    Public Function DisplayImage(ByVal img As String) As Stream
        Dim _imageStream As Stream
        Dim _assembly As [Assembly]
        _assembly = [Assembly].GetExecutingAssembly()

        Select Case img
            Case "Off_Side"
                _imageStream = _assembly.GetManifestResourceStream("FSXRemote.Off-Side.bmp")
            Case "On_Side"
                _imageStream = _assembly.GetManifestResourceStream("FSXRemote.On-Side.bmp")
            Case "Off"
                _imageStream = _assembly.GetManifestResourceStream("FSXRemote.Off.bmp")
            Case "On"
                _imageStream = _assembly.GetManifestResourceStream("FSXRemote.On.bmp")
            Case "Off_Button"
                _imageStream = _assembly.GetManifestResourceStream("FSXRemote.Off_Button.bmp")
            Case "On_Button"
                _imageStream = _assembly.GetManifestResourceStream("FSXRemote.On_Button.bmp")

            Case "HDGHOLD_ON"
                _imageStream = _assembly.GetManifestResourceStream("FSXRemote.HDGHOLD_ON.jpg")

            Case "HDGHOLD_OFF"
                _imageStream = _assembly.GetManifestResourceStream("FSXRemote.HDGHOLD_OFF.jpg")
            Case Else

        End Select

        Return _imageStream

    End Function

    Public Sub LogError(ByVal ProgPart As String, ByVal ErrMsg As String)
        Dim msg As String

        msg = Date.Now() & "," & ProgPart & "," & ErrMsg & vbCrLf

        If My.Computer.FileSystem.FileExists(".\Errors.csv") Then
            My.Computer.FileSystem.WriteAllText(".\Errors.csv", msg, True)
        Else
            My.Computer.FileSystem.WriteAllText("./ErrorLog.csv", msg, True)
        End If
    End Sub


End Module
