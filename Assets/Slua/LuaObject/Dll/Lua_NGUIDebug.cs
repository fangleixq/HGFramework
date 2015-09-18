﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_NGUIDebug : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CreateInstance_s(IntPtr l) {
		try {
			NGUIDebug.CreateInstance();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Log_s(IntPtr l) {
		try {
			System.Object[] a1;
			checkParams(l,1,out a1);
			NGUIDebug.Log(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Clear_s(IntPtr l) {
		try {
			NGUIDebug.Clear();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DrawBounds_s(IntPtr l) {
		try {
			UnityEngine.Bounds a1;
			checkType(l,1,out a1);
			NGUIDebug.DrawBounds(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_debugRaycast(IntPtr l) {
		try {
			pushValue(l,NGUIDebug.debugRaycast);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_debugRaycast(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			NGUIDebug.debugRaycast=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"NGUIDebug");
		addMember(l,CreateInstance_s);
		addMember(l,Log_s);
		addMember(l,Clear_s);
		addMember(l,DrawBounds_s);
		addMember(l,"debugRaycast",get_debugRaycast,set_debugRaycast,false);
		createTypeMetatable(l,null, typeof(NGUIDebug),typeof(UnityEngine.MonoBehaviour));
	}
}