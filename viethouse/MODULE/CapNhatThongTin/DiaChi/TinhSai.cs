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

namespace viethouse.MODULE.CapNhatThongTin.DiaChi
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The TinhSai recording.
    /// </summary>
    [TestModule("ed4ccee2-c498-4ea3-9811-b5ba619f151c", ModuleType.Recording, 1)]
    public partial class TinhSai : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::viethouse.viethouseRepository repository.
        /// </summary>
        public static global::viethouse.viethouseRepository repo = global::viethouse.viethouseRepository.Instance;

        static TinhSai instance = new TinhSai();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TinhSai()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TinhSai Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ThongTinTaiKhoản2.Select2ProvinceIdContainer' at 127;12.", repo.ThongTinTaiKhoản2.Select2ProvinceIdContainerInfo, new RecordItemIndex(0));
            repo.ThongTinTaiKhoản2.Select2ProvinceIdContainer.Click("127;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ThongTinTaiKhoản2.Search' at 105;18.", repo.ThongTinTaiKhoản2.SearchInfo, new RecordItemIndex(1));
            repo.ThongTinTaiKhoản2.Search.Click("105;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'abc' with focus on 'ThongTinTaiKhoản2.Search'.", repo.ThongTinTaiKhoản2.SearchInfo, new RecordItemIndex(2));
            repo.ThongTinTaiKhoản2.Search.PressKeys("abc");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ThongTinTaiKhoản2.KhongTimThấyKếtQuả'.", repo.ThongTinTaiKhoản2.KhongTimThấyKếtQuảInfo, new RecordItemIndex(3));
            Validate.Exists(repo.ThongTinTaiKhoản2.KhongTimThấyKếtQuảInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
