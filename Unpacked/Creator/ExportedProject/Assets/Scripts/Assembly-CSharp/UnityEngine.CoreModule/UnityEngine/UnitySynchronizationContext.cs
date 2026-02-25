namespace UnityEngine;

[Token(Token = "0x200016B")]
internal sealed class UnitySynchronizationContext : SynchronizationContext
{
	[Token(Token = "0x200016C")]
	private struct WorkRequest
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400059D")]
		private readonly SendOrPostCallback m_DelagateCallback; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400059E")]
		private readonly object m_DelagateState; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400059F")]
		private readonly ManualResetEvent m_WaitHandle; //Field offset: 0x10

		[Address(RVA = "0x89C9E0", Offset = "0x89BBE0", Length = "0x4F")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A69")]
		public WorkRequest(SendOrPostCallback callback, object state, ManualResetEvent waitHandle = null) { }

		[Address(RVA = "0x1979B40", Offset = "0x1978D40", Length = "0x1A3")]
		[CalledBy(Type = typeof(UnitySynchronizationContext), Member = "Exec", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181959FA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(BindingsMarshaller), Member = "ConvertToManaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(AsyncOperation))]
		[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000A6A")]
		public void Invoke() { }

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000599")]
	private readonly List<WorkRequest> m_AsyncWorkQueue; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400059A")]
	private readonly List<WorkRequest> m_CurrentFrameWork; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400059B")]
	private readonly int m_MainThreadID; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400059C")]
	private int m_TrackedCount; //Field offset: 0x2C

	[Token(Token = "0x1700019F")]
	internal int MainThreadId
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A5C")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0x19791A0", Offset = "0x19783A0", Length = "0xC6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A5D")]
	private UnitySynchronizationContext(int mainThreadID) { }

	[Address(RVA = "0x19790E0", Offset = "0x19782E0", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A5E")]
	private UnitySynchronizationContext(List<WorkRequest> queue, int mainThreadID) { }

	[Address(RVA = "0x1978520", Offset = "0x1977720", Length = "0xE0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A63")]
	public virtual SynchronizationContext CreateCopy() { }

	[Address(RVA = "0x1978600", Offset = "0x1977800", Length = "0x1E6")]
	[CalledBy(Type = typeof(UnitySynchronizationContext), Member = "ExecuteTasks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnitySynchronizationContext), Member = "ExecutePendingTasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UnitySynchronizationContext+WorkRequest>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UnitySynchronizationContext+WorkRequest>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WorkRequest), Member = "Invoke", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000A64")]
	public void Exec() { }

	[Address(RVA = "0x19787F0", Offset = "0x19779F0", Length = "0x153")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Stopwatch), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds", ReturnType = typeof(long))]
	[Calls(Type = typeof(UnitySynchronizationContext), Member = "Exec", ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[RequiredByNativeCode]
	[Token(Token = "0x6000A68")]
	private static bool ExecutePendingTasks(long millisecondsTimeout) { }

	[Address(RVA = "0x1978950", Offset = "0x1977B50", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
	[Calls(Type = typeof(UnitySynchronizationContext), Member = "Exec", ReturnType = typeof(void))]
	[RequiredByNativeCode]
	[Token(Token = "0x6000A67")]
	private static void ExecuteTasks() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A5C")]
	internal int get_MainThreadId() { }

	[Address(RVA = "0x19789B0", Offset = "0x1977BB0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A65")]
	private bool HasPendingTasks() { }

	[Address(RVA = "0x1978A10", Offset = "0x1977C10", Length = "0x1B1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SynchronizationContext), Member = "SetSynchronizationContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SynchronizationContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000A66")]
	private static void InitializeSynchronizationContext() { }

	[Address(RVA = "0x1978BD0", Offset = "0x1977DD0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000A61")]
	public virtual void OperationCompleted() { }

	[Address(RVA = "0x1978BE0", Offset = "0x1977DE0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000A60")]
	public virtual void OperationStarted() { }

	[Address(RVA = "0x1978BF0", Offset = "0x1977DF0", Length = "0x1E7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000A62")]
	public virtual void Post(SendOrPostCallback callback, object state) { }

	[Address(RVA = "0x1978DE0", Offset = "0x1977FE0", Length = "0x2F7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000A5F")]
	public virtual void Send(SendOrPostCallback callback, object state) { }

}

