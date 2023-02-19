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

namespace Calculator_testing
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Test1DivXNf recording.
    /// </summary>
    [TestModule("de70e35b-f3f8-41d0-8e00-a8e6b08b80f0", ModuleType.Recording, 1)]
    public partial class Test1DivXNf : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Calculator_testingRepository repository.
        /// </summary>
        public static Calculator_testingRepository repo = Calculator_testingRepository.Instance;

        static Test1DivXNf instance = new Test1DivXNf();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Test1DivXNf()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Test1DivXNf Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Калькулятор.SomeContainer.Button6' at Center.", repo.Калькулятор.SomeContainer.Button6Info, new RecordItemIndex(0));
            repo.Калькулятор.SomeContainer.Button6.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Калькулятор.SomeContainer.Button' at Center.", repo.Калькулятор.SomeContainer.ButtonInfo, new RecordItemIndex(1));
            repo.Калькулятор.SomeContainer.Button.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Калькулятор.SomeContainer.Button4' at Center.", repo.Калькулятор.SomeContainer.Button4Info, new RecordItemIndex(2));
            repo.Калькулятор.SomeContainer.Button4.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Калькулятор.SomeContainer.Button1X' at Center.", repo.Калькулятор.SomeContainer.Button1XInfo, new RecordItemIndex(3));
            repo.Калькулятор.SomeContainer.Button1X.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
