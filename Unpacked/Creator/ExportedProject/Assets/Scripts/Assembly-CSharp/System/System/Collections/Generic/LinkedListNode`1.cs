namespace System.Collections.Generic;

[Token(Token = "0x20001BB")]
public sealed class LinkedListNode
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006BF")]
	internal LinkedList<T> list; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006C0")]
	internal LinkedListNode<T> next; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006C1")]
	internal LinkedListNode<T> prev; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006C2")]
	internal T item; //Field offset: 0x0

	[Token(Token = "0x17000207")]
	public LinkedListNode<T> Next
	{
		[Address(RVA = "0xCEB970", Offset = "0xCEAB70", Length = "0x33")]
		[CalledBy(Type = typeof(ServicePointScheduler), Member = "RemoveIdleConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebConnection)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.FastAction`2", Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A", "B"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TimerThread), Member = "ThreadProc", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "Cleanup", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "GetNextOperation", ReturnType = typeof(WebOperation))]
		[CalledBy(Type = typeof(ServicePointScheduler), Member = "SchedulerIteration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ServicePointScheduler+ConnectionGroup"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ServicePointScheduler), Member = "RemoveOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation)}, ReturnType = typeof(void))]
		[CalledBy(Type = "MoonSharp.Interpreter.Table", Member = "CollectDeadKeys", ReturnType = typeof(void))]
		[CalledBy(Type = "MoonSharp.Interpreter.Table", Member = "GetNextOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.LinkedListNode`1<TablePair>"}, ReturnType = "System.Nullable`1<TablePair>")]
		[CalledBy(Type = "TMPro.FastAction", Member = "Call", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.FastAction`1", Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A"}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.FastAction`2", Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A", "B"}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.FastAction`3", Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A", "B", "C"}, ReturnType = typeof(void))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AC6")]
		 get { } //Length: 51
	}

	[Token(Token = "0x17000208")]
	public T Value
	{
		[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AC7")]
		 get { } //Length: 11
		[Address(RVA = "0xCEBB60", Offset = "0xCEAD60", Length = "0x12")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AC8")]
		 set { } //Length: 18
	}

	[Address(RVA = "0xCEB5A0", Offset = "0xCEA7A0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AC4")]
	public LinkedListNode`1(T value) { }

	[Address(RVA = "0xCEB8C0", Offset = "0xCEAAC0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AC5")]
	internal LinkedListNode`1(LinkedList<T> list, T value) { }

	[Address(RVA = "0xCEB970", Offset = "0xCEAB70", Length = "0x33")]
	[CalledBy(Type = "TMPro.FastAction`3", Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A", "B", "C"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.FastAction`2", Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A", "B"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.FastAction`1", Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.FastAction", Member = "Call", ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Table", Member = "GetNextOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.LinkedListNode`1<TablePair>"}, ReturnType = "System.Nullable`1<TablePair>")]
	[CalledBy(Type = typeof(ServicePointScheduler), Member = "RemoveOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation)}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Table", Member = "CollectDeadKeys", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "GetNextOperation", ReturnType = typeof(WebOperation))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "Cleanup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimerThread), Member = "ThreadProc", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FastAction`2", Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A", "B"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ServicePointScheduler), Member = "RemoveIdleConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebConnection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ServicePointScheduler), Member = "SchedulerIteration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ServicePointScheduler+ConnectionGroup"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AC6")]
	public LinkedListNode<T> get_Next() { }

	[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AC7")]
	public T get_Value() { }

	[Address(RVA = "0xCEB410", Offset = "0xCEA610", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AC9")]
	internal void Invalidate() { }

	[Address(RVA = "0xCEBB60", Offset = "0xCEAD60", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AC8")]
	public void set_Value(T value) { }

}

