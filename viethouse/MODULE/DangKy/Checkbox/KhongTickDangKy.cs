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

namespace viethouse.MODULE.DangKy.Checkbox
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The KhongTickDangKy recording.
    /// </summary>
    [TestModule("343fa36c-16dc-4419-8f2e-ce2aa3937347", ModuleType.Recording, 1)]
    public partial class KhongTickDangKy : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::viethouse.viethouseRepository repository.
        /// </summary>
        public static global::viethouse.viethouseRepository repo = global::viethouse.viethouseRepository.Instance;

        static KhongTickDangKy instance = new KhongTickDangKy();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public KhongTickDangKy()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static KhongTickDangKy Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ThongTinTaiKhoản.ĐăngKy' at 32;21.", repo.ThongTinTaiKhoản.ĐăngKyInfo, new RecordItemIndex(0));
            repo.ThongTinTaiKhoản.ĐăngKy.Click("32;21");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ThongTinTaiKhoản.FullName' at 212;25.", repo.ThongTinTaiKhoản.FullNameInfo, new RecordItemIndex(1));
            repo.ThongTinTaiKhoản.FullName.Click("212;25");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'gialuong{Tab}abc{LShiftKey down}@{LShiftKey up}gmail.com{Tab}0333333333{Tab}123{Tab}123' with focus on 'ThongTinTaiKhoản.FullName'.", repo.ThongTinTaiKhoản.FullNameInfo, new RecordItemIndex(2));
            repo.ThongTinTaiKhoản.FullName.PressKeys("gialuong{Tab}abc{LShiftKey down}@{LShiftKey up}gmail.com{Tab}0333333333{Tab}123{Tab}123");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ThongTinTaiKhoản.ĐăngKy1' at 251;22.", repo.ThongTinTaiKhoản.ĐăngKy1Info, new RecordItemIndex(3));
            repo.ThongTinTaiKhoản.ĐăngKy1.Click("251;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ThongTinTaiKhoản.AcceptedError'.", repo.ThongTinTaiKhoản.AcceptedErrorInfo, new RecordItemIndex(4));
            Validate.Exists(repo.ThongTinTaiKhoản.AcceptedErrorInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
