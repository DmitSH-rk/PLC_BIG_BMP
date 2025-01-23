using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using TwinCAT.Ads;
using System.Reflection;
using Microsoft.Win32;
using TwinCAT.TypeSystem;
using System.Net.Sockets;
using System.Data.Odbc;
using System.Threading;
using System.Collections.Concurrent;
using System.IO;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace Plc_forms_Big
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct BigIns
        {
            [MarshalAs(UnmanagedType.I1)]
            public bool In_1;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_2;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_3;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_4;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_5;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_6;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_7;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_8;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_9;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_10;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_11;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_12;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_13;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_14;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_15;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_16;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_17;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_18;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_19;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_20;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_21;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_22;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_23;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_24;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_25;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_26;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_27;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_28;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_29;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_30;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_31;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_32;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_33;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_34;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_35;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_36;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_37;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_38;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_39;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_40;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_41;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_42;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_43;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_44;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_45;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_46;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_47;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_48;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_49;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_50;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_51;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_52;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_53;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_54;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_55;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_56;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_57;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_58;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_59;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_60;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_61;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_62;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_63;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_64;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_65;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_66;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_67;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_68;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_69;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_70;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_71;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_72;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_73;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_74;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_75;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_76;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_77;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_78;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_79;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_80;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_81;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_82;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_83;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_84;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_85;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_86;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_87;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_88;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_89;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_90;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_91;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_92;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_93;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_94;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_95;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_96;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_97;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_98;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_99;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_100;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_101;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_102;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_103;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_104;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_105;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_106;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_107;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_108;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_109;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_110;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_111;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_112;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_113;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_114;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_115;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_116;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_117;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_118;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_119;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_120;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_121;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_122;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_123;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_124;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_125;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_126;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_127;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_128;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_129;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_130;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_131;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_132;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_133;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_134;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_135;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_136;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_137;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_138;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_139;
            [MarshalAs(UnmanagedType.I1)]
            public bool In_140;

        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct BigCounts
        {
            public uint Count_1;
            public uint Count_2;
            public uint Count_3;
            public uint Count_4;
            public uint Count_5;
            public uint Count_6;
            public uint Count_7;
            public uint Count_8;
            public uint Count_9;
            public uint Count_10;
            public uint Count_11;
            public uint Count_12;
            public uint Count_13;
            public uint Count_14;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct BigOuts
        {
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_1;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_2;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_3;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_4;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_5;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_6;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_7;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_8;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_9;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_10;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_11;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_12;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_13;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_14;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_15;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_16;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_17;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_18;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_19;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_20;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_21;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_22;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_23;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_24;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_25;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_26;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_27;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_28;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_29;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_30;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_31;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_32;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_33;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_34;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_35;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_36;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_37;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_38;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_39;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_40;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_41;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_42;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_43;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_44;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_45;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_46;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_47;
            [MarshalAs(UnmanagedType.I1)]
            public bool Out_48;

        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct BigPots
        {
            public int Pot_1;
            public int Pot_2;
            public int Pot_3;
            public int Pot_4;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct BigIncr
        {
            public int Enc_1;
            public int Enc_2;
            public int Enc_3;
            public int Enc_4;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct BigStep
        {
            public uint Step_1;
            public uint Step_2;
            public uint Step_3;
            public uint Step_4;
            public uint Step_5;
            public uint Step_6;
            public uint Step_7;
            public uint Step_8;
            public uint Step_9;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct Big_Alls
        {
            public BigIns ins_all;
            public BigOuts outs_all;
            public BigCounts counts_all;
            public BigIncr enc_all;
            public BigPots pots_all;
            public BigStep step_all;

        }

        private CancellationTokenSource _cts;
        //private Task _tcpAdsTask;
        //private Task _processQueueTask;
        private readonly ConcurrentQueue<Big_Alls> _dataQueue = new ConcurrentQueue<Big_Alls>();
        private readonly int _batchSize = 30; 
        private readonly TimeSpan _batchInterval = TimeSpan.FromMilliseconds(80);
        private readonly Mutex _queueMutex = new Mutex();
        public Big_Alls data;
        public string[] arr_i = new string[140] { "Battery1: ", "EngineSheild1: ", "EngineHeating1: ", "HeaterSpark1: ", "SideLights1: ", "SeparatorBlower1: ", "TVNLamp1: ", "SMULampS1: ", "SMULampB1: ", "DashBoardLightDay1: ", "DashBoardLightNight1: ", "NuclearShield1: ", "WaterPumpRear1: ", "WaterPumpFront1: ", "EngineCool1: ", "CentralFuelPump1: ", "GPK1: ", "TDA1: ", "SideLightB1: ", "SideLightsRear1: ", "SideLigthsAll1: ", "LeftTurn1: ", "RightTurn1: ", "Signal1: ", "PushStartAir1: ", "PushStart1: ", "EngineWaterCool1: ", "PPO_B11: ", "PPO_B21: ", "MZN1: ", "ROV1: ", "PAZ1: ", "TNPOAirFluidClear1: ", "Volt1: ", "Gear_11: ", "Gear_21: ", "Gear_31: ", "Gear_41: ", "Gear_51: ", "Gear_R1: ", "DecelaratedGear1: ", "HandBrake1: ", "ShittersOpen1: ", "ShuttersClose1: ", "Water_In1: ", "Water_Out1: ", "WaveShield_Up1: ", "WaveShield_Down1: ", "Condensate_Evac1: ", "CoolUnload1: ", "FuelTap1: ", "AirTap1: ", "DriverHatch1: ", "BackDoor1: ", "TroopsHatch1: ", "MainFriction1: ", "EngineShieldVlave1: ", "HeaterDoorTap1: ", "HeaterFuelTap1: ", "TVNEPower1: ", "TNPOPower1: ", "HeaterBoth1: ", "TurretLock1: ", "GunLock1: ", "GunnerHatch1: ", "PKT_cock1: ", "PKT_protector1: ", "G2A42_man_rel1: ", "PKT_man_rel1: ", "G2A42_release1: ", "PKT_release1: ", "AutoMode1: ", "StabilizerDrive1: ", "Shutter1: ", "Lighting1: ", "AimActiveMode1: ", "Heating1: ", "OverLoadProt1: ", "Launch1: ", "B11: ", "B21: ", "B31: ", "SW01: ", "SW11: ", "SW21: ", "SW31: ", "SW41: ", "SingleShot1: ", "LowRateShot1: ", "HighRateShot1: ", "BoundedBurst1: ", "GunTrigOn1: ", "GunOutfitPrep1: ", "RealoadGun1: ", "CountingAmmo1: ", "ControlAmmo1: ", "RewCartBelt_O1: ", "RewCartBetl_B1: ", "FG_1261: ", "PTUR1: ", "AirEjection1: ", "AzimuthGaugeL1: ", "U9SH119M11: ", "V_StabFuse1: ", "H_StabFuse1: ", "PT200CFuse1: ", "S902BFuse1: ", "TriggFuse1: ", "AirEjecFunFuse1: ", "OU5Fuse1: ", "TurretLock2: ", "CommandHatch1: ", "G2A42_release2: ", "PKT_release2: ", "AutoMode2: ", "StabilDrive1: ", "Ligting1: ", "Heating2: ", "Zoom_41: ", "Filter01: ", "Filter11: ", "Filter21: ", "Shutter2: ", "Blind1: ", "Day_Night1: ", "TKN3BPower1: ", "OU3GA42_light1: ", "OverrideGunLay1: ", "AimHold1: ", "G2A42_cock1: ", "G2A42_Prot1: ", "G2A42_Selec_O1: ", "PnevStart1: ", "ClearPrib1: ", "PKT-rel_in_manual1: ", "G2A42-rel_in_manual1: ", "SwitchesHeat1: ", "Trops1: ", "G2A42_choise_O1: ", "G2A42_choise_B1: " };
        public string[] arr_c = new string[14]  { "Gas: ", "Brake: ", "Coupling: ", "Steering: ", "ConsolePosition_1: ", "ArmsPosition_1: ", "ConsolePosition_2: ", "ArmsPosition_2: ", "TurretHand: ", "GunHand: ", "H_pos: ", "V_pos: ", "Nums: ", "Crosshair: " };
        public string[] arr_p = new string[4] { "GNPos_1: ", "VNPos_1: ", "GNPos_2: ", "VNPos_2: " };
        public string[] arr_e = new string[4] { "Brightness_1: ", "Brightness_2: ", "Diafragma: ", "Shutter: " };
        public string[] arr_s = new string[9] { "Speedometr: ", "Tachometr: ", "TransmissionOilPress: ", "SystemAirPress: ", "Voltage: ", "EngineCoolTemp: ", "EngineOilTemp: ", "EngineOilPress: ", "AzimuthMark: " };
        public string[] arr_o = new string[48] { "HandBrake1: ", "Sidelights1: ", "OutOfVehicleLeft1: ", "OutOfVehicleRight1: ", "EngWaterCoolLamp1: ", "DustSuctionLamp1: ", "PPO_B1_Lamp1: ", "PPO_B2_Lamp1: ", "EjectorDoorLamp1: ", "DoorLamp1: ", "TroopsHatchLamp1: ", "FPT_Lamp1: ", "EngineSheildValveLamp1: ", "DriverHatchLamp1: ", "PowerLamp1: ", "H_DriveLamp1: ", "V_DriveLamp1: ", "AutoLamp1: ", "SemiAutoLamp1: ", "PTRLamp1: ", "PassiveMode_Lamp1: ", "ActiveMode_Lamp1: ", "Launch_Lamp1: ", "GunTrigReadyLamp1: ", "Gun2A42ReadyLamp1: ", "HatchOpenLamp1: ", "OU5Lamp1: ", "H_DriveLamp2: ", "V_DriveLamp2: ", "AutoLamp2: ", "SemiAutoLamp2: ", "PTRLamp2: ", "AzimuthMarkLight1: ", "ResetPower1: ", "ResetPower2: ", "Magnit1: ", "Tachometr1: ", "LightHeating1: ", "BatteryActive1: ", "BatteryActive2: ", "41", "42", "43", "44", "45", "46", "47", "48" };
        public Dictionary<string, bool> Items { get; private set; }
        public Dictionary<string, uint> Count_It { get; private set; }
        public Dictionary<string, int> Pot_It { get; private set; }
        public Dictionary<string, int> Enc_It { get; private set; }
        public Dictionary<string, uint> Step_It { get; private set; }
        public Dictionary<string, bool> Out_It { get; private set; }

        public TcAdsClient Connect_to_ADS(String AmsAdrss, int port)
        {
            
            TcAdsClient plc = new TcAdsClient();
           
            plc.Connect(AmsAdrss, port);
            Console.WriteLine("Connected successfully");
            return plc;
         
        }

        public TcpClient Conn_Tcp(String targetId, int tarport)
        {
            TcpClient client = new TcpClient();
            client.Connect(targetId, tarport);
            return client;
        }

        public Big_Alls Read_package_ADS(TcAdsClient plc, String var_name)
        {
            
            int handle = plc.CreateVariableHandle(var_name);
            try
            {
                Big_Alls data = (Big_Alls)plc.ReadAny(handle, typeof(Big_Alls));
                return data;
            }
            finally
            {
                plc.DeleteVariableHandle(handle);
                
            }
        }

        public void Write_package_ADS(TcAdsClient plc, String var_name, BigOuts alls)
        {
            try
            {
                int handle = plc.CreateVariableHandle(var_name);
                plc.WriteAny(handle, alls);
                plc.DeleteVariableHandle(handle);
            } catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Add_to_LB(Big_Alls data, ListBox list_ins, ListBox list_count, ListBox list_pots, ListBox list_ens, ListBox list_outs, ListBox list_step)
        {
            /*
            list_ins.Items.Clear();
            list_count.Items.Clear();
            list_pots.Items.Clear();
            list_ens.Items.Clear();
            list_outs.Items.Clear();
            list_step.Items.Clear();
            list_ins.Items.Add("Battery: "+data.ins_all.In_1);
            list_ins.Items.Add("EngineSheild: "+data.ins_all.In_2);
            list_ins.Items.Add("EngineHeating: "+data.ins_all.In_3);
            list_ins.Items.Add("HeaterSpark: "+data.ins_all.In_4);
            list_ins.Items.Add("SideLights: "+data.ins_all.In_5);
            list_ins.Items.Add("SeparatorBlower: "+data.ins_all.In_6);
            list_ins.Items.Add("TVNLamp: "+data.ins_all.In_7);
            list_ins.Items.Add("SMULampS: "+data.ins_all.In_8);
            list_ins.Items.Add("SMULampB: "+data.ins_all.In_9);
            list_ins.Items.Add("DashBoardLightDay: "+data.ins_all.In_10);
            list_ins.Items.Add("DashBoardLightNight: "+data.ins_all.In_11);
            list_ins.Items.Add("NuclearShield: "+data.ins_all.In_12);
            list_ins.Items.Add("WaterPumpRear: "+data.ins_all.In_13);
            list_ins.Items.Add("WaterPumpFront: "+data.ins_all.In_14);
            list_ins.Items.Add("EngineCool: "+data.ins_all.In_15);
            list_ins.Items.Add("CentralFuelPump: "+data.ins_all.In_16);
            list_ins.Items.Add("GPK: "+data.ins_all.In_17);
            list_ins.Items.Add("TDA: "+data.ins_all.In_18);
            list_ins.Items.Add("SideLightB: "+data.ins_all.In_19);
            list_ins.Items.Add("SideLightsRear: "+data.ins_all.In_20);
            list_ins.Items.Add("SideLigthsAll: "+data.ins_all.In_21);
            list_ins.Items.Add("LeftTurn: "+data.ins_all.In_22);
            list_ins.Items.Add("RightTurn: "+data.ins_all.In_23);
            list_ins.Items.Add("Signal: "+data.ins_all.In_24);
            list_ins.Items.Add("PushStartAir: "+data.ins_all.In_25);
            list_ins.Items.Add("PushStart: "+data.ins_all.In_26);
            list_ins.Items.Add("EngineWaterCool: "+data.ins_all.In_27);
            list_ins.Items.Add("PPO_B1: "+data.ins_all.In_28);
            list_ins.Items.Add("PPO_B2: "+data.ins_all.In_29);
            list_ins.Items.Add("MZN: "+data.ins_all.In_30);
            list_ins.Items.Add("ROV: "+data.ins_all.In_31);
            list_ins.Items.Add("PAZ: "+data.ins_all.In_32);
            list_ins.Items.Add("TNPOAirFluidClear: "+data.ins_all.In_33);
            list_ins.Items.Add("Volt: "+data.ins_all.In_34);
            list_ins.Items.Add("Gear_1: "+data.ins_all.In_35);
            list_ins.Items.Add("Gear_2: "+data.ins_all.In_36);
            list_ins.Items.Add("Gear_3: "+data.ins_all.In_37);
            list_ins.Items.Add("Gear_4: "+data.ins_all.In_38);
            list_ins.Items.Add("Gear_5: "+data.ins_all.In_39);
            list_ins.Items.Add("Gear_R: "+data.ins_all.In_40);
            list_ins.Items.Add("DecelaratedGear: "+data.ins_all.In_41);
            list_ins.Items.Add("HandBrake: "+data.ins_all.In_42);
            list_ins.Items.Add("ShittersOpen: "+data.ins_all.In_43);
            list_ins.Items.Add("ShuttersClose: "+data.ins_all.In_44);
            list_ins.Items.Add("Water_In: "+data.ins_all.In_45);
            list_ins.Items.Add("Water_Out: "+data.ins_all.In_46);
            list_ins.Items.Add("WaveShield_Up: "+data.ins_all.In_47);
            list_ins.Items.Add("WaveShield_Down: "+data.ins_all.In_48);
            list_ins.Items.Add("Condensate_Evac: "+data.ins_all.In_49);
            list_ins.Items.Add("CoolUnload: "+data.ins_all.In_50);
            list_ins.Items.Add("FuelTap: "+data.ins_all.In_51);
            list_ins.Items.Add("AirTap: "+data.ins_all.In_52);
            list_ins.Items.Add("DriverHatch: "+data.ins_all.In_53);
            list_ins.Items.Add("BackDoor: "+data.ins_all.In_54);
            list_ins.Items.Add("TroopsHatch: "+data.ins_all.In_55);
            list_ins.Items.Add("MainFriction: "+data.ins_all.In_56);
            list_ins.Items.Add("EngineShieldVlave: "+data.ins_all.In_57);
            list_ins.Items.Add("HeaterDoorTap: "+data.ins_all.In_58);
            list_ins.Items.Add("HeaterFuelTap: "+data.ins_all.In_59);
            list_ins.Items.Add("TVNEPower: "+data.ins_all.In_60);
            list_ins.Items.Add("TNPOPower: "+data.ins_all.In_61);
            list_ins.Items.Add("HeaterBoth: "+data.ins_all.In_62);
            list_ins.Items.Add("TurretLock: "+data.ins_all.In_63);
            list_ins.Items.Add("GunLock: "+data.ins_all.In_64);
            list_ins.Items.Add("GunnerHatch: "+data.ins_all.In_65);
            list_ins.Items.Add("PKT_cock: "+data.ins_all.In_66);
            list_ins.Items.Add("PKT_protector: "+data.ins_all.In_67);
            list_ins.Items.Add("G2A42_man_rel: "+data.ins_all.In_68);
            list_ins.Items.Add("PKT_man_rel: "+data.ins_all.In_69);
            list_ins.Items.Add("G2A42_release: "+data.ins_all.In_70);
            list_ins.Items.Add("PKT_release: "+data.ins_all.In_71);
            list_ins.Items.Add("AutoMode: "+data.ins_all.In_72);
            list_ins.Items.Add("StabilizerDrive: "+data.ins_all.In_73);
            list_ins.Items.Add("Shutter: "+data.ins_all.In_74);
            list_ins.Items.Add("Lighting: "+data.ins_all.In_75);
            list_ins.Items.Add("AimActiveMode: "+data.ins_all.In_76);
            list_ins.Items.Add("Heating: "+data.ins_all.In_77);
            list_ins.Items.Add("OverLoadProt: "+data.ins_all.In_78);
            list_ins.Items.Add("Launch: "+data.ins_all.In_79);
            list_ins.Items.Add("B1: "+data.ins_all.In_80);
            list_ins.Items.Add("B2: "+data.ins_all.In_81);
            list_ins.Items.Add("B3: "+data.ins_all.In_82);
            list_ins.Items.Add("SW0: "+data.ins_all.In_83);
            list_ins.Items.Add("SW1: "+data.ins_all.In_84);
            list_ins.Items.Add("SW2: "+data.ins_all.In_85);
            list_ins.Items.Add("SW3: "+data.ins_all.In_86);
            list_ins.Items.Add("SW4: "+data.ins_all.In_87);
            list_ins.Items.Add("SingleShot: "+data.ins_all.In_88);
            list_ins.Items.Add("LowRateShot: "+data.ins_all.In_89);
            list_ins.Items.Add("HighRateShot: "+data.ins_all.In_90);
            list_ins.Items.Add("BoundedBurst: "+data.ins_all.In_91);
            list_ins.Items.Add("GunTrigOn: "+data.ins_all.In_92);
            list_ins.Items.Add("GunOutfitPrep: "+data.ins_all.In_93);
            list_ins.Items.Add("RealoadGun: "+data.ins_all.In_94);
            list_ins.Items.Add("CountingAmmo: "+data.ins_all.In_95);
            list_ins.Items.Add("ControlAmmo: "+data.ins_all.In_96);
            list_ins.Items.Add("RewCartBelt_O: "+data.ins_all.In_97);
            list_ins.Items.Add("RewCartBetl_B: "+data.ins_all.In_98);
            list_ins.Items.Add("FG_126: "+data.ins_all.In_99);
            list_ins.Items.Add("PTUR: "+data.ins_all.In_100);
            list_ins.Items.Add("AirEjection: "+data.ins_all.In_101);
            list_ins.Items.Add("AzimuthGaugeL: "+data.ins_all.In_102);
            list_ins.Items.Add("U9SH119M1: "+data.ins_all.In_103);
            list_ins.Items.Add("V_StabFuse: "+data.ins_all.In_104);
            list_ins.Items.Add("H_StabFuse: "+data.ins_all.In_105);
            list_ins.Items.Add("PT200CFuse: "+data.ins_all.In_106);
            list_ins.Items.Add("S902BFuse: "+data.ins_all.In_107);
            list_ins.Items.Add("TriggFuse: "+data.ins_all.In_108);
            list_ins.Items.Add("AirEjecFunFuse: "+data.ins_all.In_109);
            list_ins.Items.Add("OU5Fuse: "+data.ins_all.In_110);
            list_ins.Items.Add("TurretLock: "+data.ins_all.In_111);
            list_ins.Items.Add("CommandHatch: "+data.ins_all.In_112);
            list_ins.Items.Add("G2A42_release: "+data.ins_all.In_113);
            list_ins.Items.Add("PKT_release: "+data.ins_all.In_114);
            list_ins.Items.Add("AutoMode: "+data.ins_all.In_115);
            list_ins.Items.Add("StabilDrive: "+data.ins_all.In_116);
            list_ins.Items.Add("Ligting: "+data.ins_all.In_117);
            list_ins.Items.Add("Heating: "+data.ins_all.In_118);
            list_ins.Items.Add("Zoom_4: "+data.ins_all.In_119);
            list_ins.Items.Add("Filter0: "+data.ins_all.In_120);
            list_ins.Items.Add("Filter1: "+data.ins_all.In_121);
            list_ins.Items.Add("Filter2: "+data.ins_all.In_122);
            list_ins.Items.Add("Shutter: "+data.ins_all.In_123);
            list_ins.Items.Add("Blind: "+data.ins_all.In_124);
            list_ins.Items.Add("Day_Night: "+data.ins_all.In_125);
            list_ins.Items.Add("TKN3BPower: "+data.ins_all.In_126);
            list_ins.Items.Add("OU3GA42_light: "+data.ins_all.In_127);
            list_ins.Items.Add("OverrideGunLay: "+data.ins_all.In_128);
            list_ins.Items.Add("AimHold: "+data.ins_all.In_129);
            list_ins.Items.Add("G2A42_cock: "+data.ins_all.In_130);
            list_ins.Items.Add("G2A42_Prot: "+data.ins_all.In_131);
            list_ins.Items.Add("G2A42_Selec_O: "+data.ins_all.In_132);
            list_ins.Items.Add("PnevStart: "+data.ins_all.In_133);
            list_ins.Items.Add("ClearPrib: "+data.ins_all.In_134);
            list_ins.Items.Add("PKT-rel_in_manual: "+data.ins_all.In_135);
            list_ins.Items.Add("G2A42-rel_in_manual: "+data.ins_all.In_136);
            list_ins.Items.Add("SwitchesHeat: "+data.ins_all.In_137);
            list_ins.Items.Add("Trops: "+data.ins_all.In_138);
            list_ins.Items.Add("G2A42_choise_O: "+data.ins_all.In_139);
            list_ins.Items.Add("G2A42_choise_B: "+data.ins_all.In_140);
 
            list_count.Items.Add("Gas: " + data.counts_all.Count_1);
            list_count.Items.Add("Brake: " + data.counts_all.Count_2);
            list_count.Items.Add("Coupling: " + data.counts_all.Count_3);
            list_count.Items.Add("Steering: " + data.counts_all.Count_4);
            list_count.Items.Add("ConsolePosition: " + data.counts_all.Count_5);
            list_count.Items.Add("ArmsPosition: " + data.counts_all.Count_6);
            list_count.Items.Add("ConsolePosition: " + data.counts_all.Count_7);
            list_count.Items.Add("ArmsPosition: " + data.counts_all.Count_8);
            list_count.Items.Add("TurretHand: " + data.counts_all.Count_9);
            list_count.Items.Add("GunHand: " + data.counts_all.Count_10);
            list_count.Items.Add("H_pos: " + data.counts_all.Count_11);
            list_count.Items.Add("V_pos: " + data.counts_all.Count_12);
            list_count.Items.Add("Nums: " + data.counts_all.Count_13);
            list_count.Items.Add("Crosshair: " + data.counts_all.Count_14);
                    
            list_pots.Items.Add("GNPos: " + data.pots_all.Pot_1);
            list_pots.Items.Add("VNPos: " + data.pots_all.Pot_2);
            list_pots.Items.Add("GNPos: " + data.pots_all.Pot_3);
            list_pots.Items.Add("VNPos: " + data.pots_all.Pot_4);              
                    
            list_ens.Items.Add("Brightness: "+ data.enc_all.Enc_1);
            list_ens.Items.Add("Brightness: " + data.enc_all.Enc_2);
            list_ens.Items.Add("Diafragma: " + data.enc_all.Enc_3);
            list_ens.Items.Add("Shutter: " + data.enc_all.Enc_4);
               
            list_step.Items.Add("Speedometr: "+data.step_all.Step_1);
            list_step.Items.Add("Tachometr: "+data.step_all.Step_2);
            list_step.Items.Add("TransmissionOilPress: "+data.step_all.Step_3);
            list_step.Items.Add("SystemAirPress: "+data.step_all.Step_4);
            list_step.Items.Add("Voltage: "+data.step_all.Step_5);
            list_step.Items.Add("EngineCoolTemp: "+data.step_all.Step_6);
            list_step.Items.Add("EngineOilTemp: "+data.step_all.Step_7);
            list_step.Items.Add("EngineOilPress: "+data.step_all.Step_8);
            list_step.Items.Add("AzimuthMark: "+data.step_all.Step_9);

            list_outs.Items.Add("HandBrake: "+data.outs_all.Out_1);
            list_outs.Items.Add("Sidelights: "+data.outs_all.Out_2);
            list_outs.Items.Add("OutOfVehicleLeft: "+data.outs_all.Out_3);
            list_outs.Items.Add("OutOfVehicleRight: "+data.outs_all.Out_4);
            list_outs.Items.Add("EngWaterCoolLamp: "+data.outs_all.Out_5);
            list_outs.Items.Add("DustSuctionLamp: "+data.outs_all.Out_6);
            list_outs.Items.Add("PPO_B1_Lamp: "+data.outs_all.Out_7);
            list_outs.Items.Add("PPO_B2_Lamp: "+data.outs_all.Out_8);
            list_outs.Items.Add("EjectorDoorLamp: "+data.outs_all.Out_9);
            list_outs.Items.Add("DoorLamp: "+data.outs_all.Out_10);
            list_outs.Items.Add("TroopsHatchLamp: "+data.outs_all.Out_11);
            list_outs.Items.Add("FPT_Lamp: "+data.outs_all.Out_12);
            list_outs.Items.Add("EngineSheildValveLamp: "+data.outs_all.Out_13);
            list_outs.Items.Add("DriverHatchLamp: "+data.outs_all.Out_14);
            list_outs.Items.Add("PowerLamp: "+data.outs_all.Out_15);
            list_outs.Items.Add("H_DriveLamp: "+data.outs_all.Out_16);
            list_outs.Items.Add("V_DriveLamp: "+data.outs_all.Out_17);
            list_outs.Items.Add("AutoLamp: "+data.outs_all.Out_18);
            list_outs.Items.Add("SemiAutoLamp: "+data.outs_all.Out_19);
            list_outs.Items.Add("PTRLamp: "+data.outs_all.Out_20);
            list_outs.Items.Add("PassiveMode_Lamp: "+data.outs_all.Out_21);
            list_outs.Items.Add("ActiveMode_Lamp: "+data.outs_all.Out_22);
            list_outs.Items.Add("Launch_Lamp: "+data.outs_all.Out_23);
            list_outs.Items.Add("GunTrigReadyLamp: "+data.outs_all.Out_24);
            list_outs.Items.Add("Gun2A42ReadyLamp: "+data.outs_all.Out_25);
            list_outs.Items.Add("HatchOpenLamp: "+data.outs_all.Out_26);
            list_outs.Items.Add("OU5Lamp: "+data.outs_all.Out_27);
            list_outs.Items.Add("H_DriveLamp: "+data.outs_all.Out_28);
            list_outs.Items.Add("V_DriveLamp: "+data.outs_all.Out_29);
            list_outs.Items.Add("AutoLamp: "+data.outs_all.Out_30);
            list_outs.Items.Add("SemiAutoLamp: "+data.outs_all.Out_31);
            list_outs.Items.Add("PTRLamp: "+data.outs_all.Out_32);
            list_outs.Items.Add("AzimuthMarkLight: "+data.outs_all.Out_33);
            list_outs.Items.Add("ResetPower: "+data.outs_all.Out_34);
            list_outs.Items.Add("ResetPower: "+data.outs_all.Out_35);
            list_outs.Items.Add("Magnit: "+data.outs_all.Out_36);
            list_outs.Items.Add("Tachometr: "+data.outs_all.Out_37);
            list_outs.Items.Add("LightHeating: "+data.outs_all.Out_38);
            list_outs.Items.Add("BatteryActive: "+data.outs_all.Out_39);
            list_outs.Items.Add("BatteryActive: "+data.outs_all.Out_40);*/
            try
            {
                Items.Clear();
                Count_It.Clear();
                Pot_It.Clear();
                Enc_It.Clear();
                Step_It.Clear();
                Out_It.Clear();

                Type type = typeof(BigIns);
                FieldInfo[] fields = type.GetFields();
                foreach (FieldInfo field in fields)
                {
                    string fieldName = field.Name;

                    if (fieldName.StartsWith("In_"))
                    {
                        string numberStr = fieldName.Substring(3);
                        if (int.TryParse(numberStr, out int number))
                        {
                            int i = number - 1;
                            bool value = (bool)field.GetValue(data.ins_all);
                            Items.Add(arr_i[i], value);
                        }
                    }
                }
                list_ins.ItemsSource = null;
                list_ins.ItemsSource = Items;

                Type type_c = typeof(BigCounts);
                FieldInfo[] fields_c = type_c.GetFields();
                foreach (FieldInfo field in fields_c)
                {
                    string fieldName = field.Name;

                    if (fieldName.StartsWith("Count_"))
                    {
                        string numberStr = fieldName.Substring(6);
                        if (int.TryParse(numberStr, out int number))
                        {
                            int i = number - 1;
                            uint value = (uint)field.GetValue(data.counts_all);
                            Count_It.Add(arr_c[i], value);
                        }
                    }
                }
                list_count.ItemsSource = null;
                list_count.ItemsSource = Count_It;

                Type type_p = typeof(BigPots);
                FieldInfo[] fields_p = type_p.GetFields();
                foreach (FieldInfo field in fields_p)
                {
                    string fieldName = field.Name;

                    if (fieldName.StartsWith("Pot_"))
                    {
                        string numberStr = fieldName.Substring(4);
                        if (int.TryParse(numberStr, out int number))
                        {
                            int i = number - 1;
                            int value = (int)field.GetValue(data.pots_all);
                            Pot_It.Add(arr_p[i], value);
                        }
                    }
                }
                list_pots.ItemsSource = null;
                list_pots.ItemsSource = Pot_It;

                Type type_e = typeof(BigIncr);
                FieldInfo[] fields_e = type_e.GetFields();
                foreach (FieldInfo field in fields_e)
                {
                    string fieldName = field.Name;

                    if (fieldName.StartsWith("Enc_"))
                    {
                        string numberStr = fieldName.Substring(4);
                        if (int.TryParse(numberStr, out int number))
                        {
                            int i = number - 1;
                            int value = (int)field.GetValue(data.enc_all);
                            Enc_It.Add(arr_e[i], value);
                        }
                    }
                }
                list_ens.ItemsSource = null;
                list_ens.ItemsSource = Enc_It;

                Type type_s = typeof(BigStep);
                FieldInfo[] fields_s = type_s.GetFields();
                foreach (FieldInfo field in fields_s)
                {
                    string fieldName = field.Name;

                    if (fieldName.StartsWith("Step_"))
                    {
                        string numberStr = fieldName.Substring(5);
                        if (int.TryParse(numberStr, out int number))
                        {
                            int i = number - 1;
                            uint value = (uint)field.GetValue(data.step_all);
                            Step_It.Add(arr_s[i], value);
                        }
                    }
                }
                list_step.ItemsSource = null;
                list_step.ItemsSource = Step_It;


                Type type_o = typeof(BigOuts);
                FieldInfo[] fields_o = type_o.GetFields();
                foreach (FieldInfo field in fields_o)
                {
                    string fieldName = field.Name;

                    if (fieldName.StartsWith("Out_"))
                    {
                        string numberStr = fieldName.Substring(4);
                        if (int.TryParse(numberStr, out int number))
                        {
                            int i = number - 1;
                            bool value = (bool)field.GetValue(data.outs_all);
                            Out_It.Add(arr_o[i], value);
                        }
                    }
                }
                list_outs.ItemsSource = null;
                list_outs.ItemsSource = Out_It;
            } catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }

        public static byte[] To_Byte_arr(Big_Alls data)
        {
            int size = Marshal.SizeOf(data);
            byte[] arr = new byte[512];
            IntPtr ptr = Marshal.AllocHGlobal(512);

            try
            {
                Marshal.StructureToPtr(data, ptr, true);
                Marshal.Copy(ptr, arr, 0, 512);
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }

            return arr;
        }

        public static Big_Alls From_Byte_arr(byte[] arr)
        {
            Big_Alls data = new Big_Alls();
            int size = 512;
            if (arr.Length != size)
                throw new ArgumentException($"Неверный размер массива. Ожидалось {size} байт, получено {arr.Length} байт.");

            IntPtr ptr = Marshal.AllocHGlobal(size);
            try
            {
                Marshal.Copy(arr, 0, ptr, size);
                data = (Big_Alls)Marshal.PtrToStructure(ptr, typeof(Big_Alls));
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }

            return data;
        }

        public void Transmit(TcpClient client, Big_Alls data, NetworkStream stream)
        {
            
            byte[] message = To_Byte_arr(data);

            stream.Write(message, 0, 512);

        }

        public Big_Alls Receive(TcpClient client, NetworkStream stream)
        {
           
            int size = Marshal.SizeOf(typeof(Big_Alls));
            byte[] buffer = new byte[512];
            int totalRead = 0;


            int read = stream.Read(buffer, 0, 512);
            if (read == 0)
            {
                throw new Exception("Соединение закрыто.");
            }
            totalRead += read;


            Big_Alls data = From_Byte_arr(buffer);
            Dispatcher.Invoke(() => { BufferFirst.Content = data.ins_all.In_2; });
            Console.WriteLine("Данные получены.");
            return data;
        }

        private void ProcessDataQueueAsync(CancellationToken cancellationToken)
        {
            try
            {   
                while (!cancellationToken.IsCancellationRequested)
                {
                    List<Big_Alls> batch = new List<Big_Alls>();

                    _queueMutex.WaitOne();
                    while (batch.Count < _batchSize && _dataQueue.TryDequeue(out var data))
                    {
                        batch.Add(data);
                    }
                    _queueMutex.ReleaseMutex();

                    if (batch.Count > 0)
                    {
                        Dispatcher.Invoke(() =>
                            {
                                foreach (var item in batch)
                                {
                                    Add_to_LB(item, InsList, MabList, PotList, EncList, OutList, StepList);
                                }
                            });
                       
                    }

                    Thread.Sleep(_batchInterval);
                }
            }
            catch (OperationCanceledException)
            {
                // Задача была отменена
            }
            catch (Exception ex)
            { 
                Dispatcher.Invoke(() =>
                {
                    MessageBox.Show($"Ошибка в ProcessDataQueueAsync: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                });
            }
        }

        public void TcpAds(String AMS, int port, CancellationToken cancellationToken, TcpClient client, TcAdsClient plc)
        {

            String var_name = "MAIN.Big_All_Data";

            while (!cancellationToken.IsCancellationRequested)
            {
                NetworkStream stream = client.GetStream();
                Stopwatch sw = Stopwatch.StartNew();
                new Thread(() =>
                {                  
                    data = Read_package_ADS(plc, var_name);
                    Transmit(client, data, stream);
                    _queueMutex.WaitOne();
                    _dataQueue.Enqueue(data);
                    _queueMutex.ReleaseMutex();
                    Thread.Sleep(TimeSpan.FromMilliseconds(5));
                })
                { IsBackground = true }.Start();

                new Thread(() =>
                {
                    Big_Alls dataRec = Receive(client, stream);
                    Write_package_ADS(plc, "MAIN.Big_Out", dataRec.outs_all);
                })
                { IsBackground = true}.Start();
                    
                sw.Stop();
                //_dataQueue.Enqueue(data);

                Dispatcher.Invoke(() =>
                {
                    TimeLabel.Content = sw.Elapsed.TotalMilliseconds.ToString("F2") + " ms";
                });
            }
            plc.Dispose();
            client.Close();
        }
        
        /*public async Task Transmit(TcpClient client, Big_Alls data, NetworkStream stream)
        {
            //NetworkStream stream = client.GetStream();
            byte[] message = To_Byte_arr(data); // Предположим, что этот метод реализован
            
            await stream.WriteAsync(message, 0, 512);

        }

        public async Task<Big_Alls> Receive(TcpClient client, NetworkStream stream) {
            //NetworkStream stream = client.GetStream();
            int size = Marshal.SizeOf(typeof(Big_Alls));
            byte[] buffer = new byte[512];
            int totalRead = 0;

            
            int read = await stream.ReadAsync(buffer, 0, 512);
            if (read == 0)
            {
                throw new Exception("Соединение закрыто.");
            }
            totalRead += read;
            

            Big_Alls data = From_Byte_arr(buffer);
            await Dispatcher.InvokeAsync(() => { BufferFirst.Content = data.ins_all.In_2; });
            Console.WriteLine("Данные получены.");
            return data;
        }

        private async Task ProcessDataQueueAsync(CancellationToken cancellationToken)
        {
            try
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    List<Big_Alls> batch = new List<Big_Alls>();
                    while (batch.Count < _batchSize && _dataQueue.TryDequeue(out var data))
                    {
                        batch.Add(data);
                    }

                    if (batch.Count > 0)
                    {
                        // Обновление UI пакетами
                        await Dispatcher.InvokeAsync(() =>
                        {
                            foreach (var item in batch)
                            {
                                Add_to_LB(item, InsList, MabList, PotList, EncList, OutList, StepList);
                            }
                        });
                    }

                    // Ожидание перед следующей проверкой
                    await Task.Delay(_batchInterval, cancellationToken);
                }
            }
            catch (OperationCanceledException)
            {
                // Задача была отменена
            }
            catch (Exception ex)
            {
                // Обработка других исключений
                Dispatcher.Invoke(() =>
                {
                    MessageBox.Show($"Ошибка в ProcessDataQueueAsync: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                });
            }
        }

        public async Task TcpAds(String AMS, int port, String targetIp, int tarport, CancellationToken cancellationToken, TcpClient client) {
            
            String var_name = "MAIN.Big_All_Data";
            TcAdsClient plc = Connect_to_ADS(AMS, port);
            
            while (!cancellationToken.IsCancellationRequested)
            {
                NetworkStream stream = client.GetStream();
                Stopwatch sw = Stopwatch.StartNew();
                data = await Task.Run(() => Read_package_ADS(plc, var_name), cancellationToken);

                _ = Transmit(client, data, stream);
                _dataQueue.Enqueue(data);

                Big_Alls dataRec = await Receive(client, stream);
                _dataQueue.Enqueue(dataRec);

                int handle = plc.CreateVariableHandle("MAIN.Big_Out");
                plc.WriteAny(handle, dataRec.outs_all);
                sw.Stop();
               

                await Dispatcher.InvokeAsync(() =>
                {
                    TimeLabel.Content = sw.Elapsed.TotalMilliseconds.ToString("F2") + " ms";
                });
            }
            plc.Dispose();
            client.Close();
        }
        */

        private void StopBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_cts != null && !_cts.IsCancellationRequested)
            {
                _cts.Cancel();
            }
        }

        private void StartBtn_Click(object sender,  RoutedEventArgs e) {
            //"5.114.111.44.1.1"; 801; 127.0.0.1; 2222;
            String AMS = AmsIdBox.Text;
            String targetIp = TargetIdBox.Text;
            int port = int.Parse(AmsPortBox.Text);
            int tarport = int.Parse(TargetPortBox.Text);
            _cts = new CancellationTokenSource();

            try
            {
                TcpClient client = Conn_Tcp(targetIp, tarport);
                if (client == null)
                {
                    MessageBox.Show("Отсутсвует подлкючение TCP");
                }
                /*_tcpAdsTask = TcpAds(AMS, port, targetIp, tarport, _cts.Token, client);
                _processQueueTask = ProcessDataQueueAsync(_cts.Token);
                await Task.WhenAll(_tcpAdsTask, _processQueueTask);*/
                TcAdsClient plc = Connect_to_ADS(AMS, port);
                new Thread(() => TcpAds(AMS, port, _cts.Token, client, plc)).Start();
                new Thread(() => ProcessDataQueueAsync(_cts.Token)).Start();
                
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                _cts.Cancel();
            }

        }
        private void Switch(object sender, RoutedEventArgs e) { 
            string new_text = SwicthBox.Text;
            int pos = int.Parse(PosText.Text);
            arr_i[pos - 1] = new_text;
        }
        public MainWindow()
        {
            Items = new Dictionary<string, bool>();
            Count_It = new Dictionary<string, uint>();
            Pot_It = new Dictionary<string, int>();
            Enc_It = new Dictionary<string, int>();
            Step_It = new Dictionary<string, uint>();
            Out_It = new Dictionary<string, bool>();
            InitializeComponent();
        }
    }
}

