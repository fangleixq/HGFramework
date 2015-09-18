﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_LagRotation : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnRepositionEnd(IntPtr l) {
		try {
			LagRotation self=(LagRotation)checkSelf(l);
			self.OnRepositionEnd();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_speed(IntPtr l) {
		try {
			LagRotation self=(LagRotation)checkSelf(l);
			pushValue(l,self.speed);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_speed(IntPtr l) {
		try {
			LagRotation self=(LagRotation)checkSelf(l);
			System.Single v;
			checkType(l,2,out v);
			self.speed=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ignoreTimeScale(IntPtr l) {
		try {
			LagRotation self=(LagRotation)checkSelf(l);
			pushValue(l,self.ignoreTimeScale);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ignoreTimeScale(IntPtr l) {
		try {
			LagRotation self=(LagRotation)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.ignoreTimeScale=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"LagRotation");
		addMember(l,OnRepositionEnd);
		addMember(l,"speed",get_speed,set_speed,true);
		addMember(l,"ignoreTimeScale",get_ignoreTimeScale,set_ignoreTimeScale,true);
		createTypeMetatable(l,null, typeof(LagRotation),typeof(UnityEngine.MonoBehaviour));
	}
}