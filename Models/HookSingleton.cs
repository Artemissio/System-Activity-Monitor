﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemActivityMonitor.CommandPattern;

namespace SystemActivityMonitor.Models
{
    public class HookSingleton
    {
        static HookSingleton Hook;
        private readonly List<KeyboardHookModel> keyboardHooks;
        private readonly List<MouseHookModel> mouseHooks;
        readonly MouseHook mouseHook;
        readonly KeyboardHook keyboardHook;

        readonly Client client;

        public static HookSingleton GetInstance()
        {
            if (Hook == null)
                Hook = new HookSingleton();
            return Hook;
        }

        HookSingleton()
        {
            keyboardHook = new KeyboardHook();
            mouseHook = new MouseHook();

            client = new Client();

            keyboardHooks = new List<KeyboardHookModel>();
            mouseHooks = client.GetMouseHooks();

            mouseHook.MouseDown += new MouseEventHandler(client.MouseDown);
            mouseHook.MouseUp += new MouseEventHandler(client.MouseUp);
            mouseHook.MouseWheel += new MouseEventHandler(client.MouseWheel);

            keyboardHook.KeyDown += new KeyboardHook.KeyboardHookCallback(KeyboardHook_KeyUp);
            keyboardHook.KeyUp += new KeyboardHook.KeyboardHookCallback(KeyboardHook_KeyDown);

            mouseHook.Execute();
            keyboardHook.Execute();          
        }

        public List<KeyboardHookModel> GetKeyboardHooks()
        {
            return keyboardHooks;
        }

        public List<MouseHookModel> GetMouseHooks()
        {
            return mouseHooks;
        }  

        private void KeyboardHook_KeyUp(VKeys key)
        {
            keyboardHooks.Insert(0, new KeyboardHookModel
            {
                EventType = "Key Up",
                KeyChar = key.ToString(),
                Time = DateTime.Now.ToString()
            });
        }

        private void KeyboardHook_KeyDown(VKeys key)
        {
            keyboardHooks.Insert(0, new KeyboardHookModel
            {
                EventType = "Key Down",
                KeyChar = key.ToString(),
                Time = DateTime.Now.ToString()
            });
        }
    }
}