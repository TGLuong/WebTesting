﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace viethouse.MODULE.CapNhatThongTin
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The HoTen10KyTu recording.
    /// </summary>
    [TestModule("66aa08c4-1cdb-4725-9e93-6979ef4bb4ba", ModuleType.Recording, 1)]
    public partial class HoTen10KyTu : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::viethouse.viethouseRepository repository.
        /// </summary>
        public static global::viethouse.viethouseRepository repo = global::viethouse.viethouseRepository.Instance;

        static HoTen10KyTu instance = new HoTen10KyTu();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public HoTen10KyTu()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static HoTen10KyTu Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ThongTinTaiKhoản2.ProfileFullName' at 187;18.", repo.ThongTinTaiKhoản2.ProfileFullNameInfo, new RecordItemIndex(0));
            repo.ThongTinTaiKhoản2.ProfileFullName.Click("187;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ThongTinTaiKhoản2.ProfileFullName'.", repo.ThongTinTaiKhoản2.ProfileFullNameInfo, new RecordItemIndex(1));
            Keyboard.PrepareFocus(repo.ThongTinTaiKhoản2.ProfileFullName);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'ThongTinTaiKhoản2.ProfileFullName'.", repo.ThongTinTaiKhoản2.ProfileFullNameInfo, new RecordItemIndex(2));
            repo.ThongTinTaiKhoản2.ProfileFullName.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Tran Gia L' with focus on 'ThongTinTaiKhoản2.ProfileFullName'.", repo.ThongTinTaiKhoản2.ProfileFullNameInfo, new RecordItemIndex(3));
            repo.ThongTinTaiKhoản2.ProfileFullName.PressKeys("Tran Gia L");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ThongTinTaiKhoản2.ChangeInfo' at 130;26.", repo.ThongTinTaiKhoản2.ChangeInfoInfo, new RecordItemIndex(4));
            repo.ThongTinTaiKhoản2.ChangeInfo.Click("130;26");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ThongTinTaiKhoản2.CậpNhậtThongTinTaiKhoảnThanhCong'.", repo.ThongTinTaiKhoản2.CậpNhậtThongTinTaiKhoảnThanhCongInfo, new RecordItemIndex(5));
            Validate.Exists(repo.ThongTinTaiKhoản2.CậpNhậtThongTinTaiKhoảnThanhCongInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ThongTinTaiKhoảnGoogleChrome.TảiLại' at 22;20.", repo.ThongTinTaiKhoảnGoogleChrome.TảiLạiInfo, new RecordItemIndex(6));
            repo.ThongTinTaiKhoảnGoogleChrome.TảiLại.Click("22;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Tran Gia L') on item 'ThongTinTaiKhoản2.ProfileFullName'.", repo.ThongTinTaiKhoản2.ProfileFullNameInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.ThongTinTaiKhoản2.ProfileFullNameInfo, "Value", "Tran Gia L");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
