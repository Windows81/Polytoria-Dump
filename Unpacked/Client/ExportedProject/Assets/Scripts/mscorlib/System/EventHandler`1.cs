namespace System;

[Token(Token = "0x20000D5")]
public sealed class EventHandler : MulticastDelegate
{

	[Address(RVA = "0xC2F920", Offset = "0xC2EB20", Length = "0x125")]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyDataSourceTracker", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.DataBindingManager"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Columns", Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Column"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.Columns", Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.UIElements.Column"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.MultiColumnListView", Member = "set_columns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Columns"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.MultiColumnTreeView", Member = "set_columns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Columns"}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x60006A1")]
	public EventHandler`1(object object, IntPtr method) { }

	[Address(RVA = "0xC2F890", Offset = "0xC2EA90", Length = "0x89")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006A2")]
	public override void Invoke(object sender, TEventArgs e) { }

}

