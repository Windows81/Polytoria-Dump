namespace UnityEngine;

[AsyncMethodBuilder(typeof(AwaitableAsyncMethodBuilder))]
[NativeHeader("Runtime/Mono/AsyncOperationAwaitable.h")]
[NativeHeader("Runtime/Mono/DelayedCallAwaitable.h")]
[NativeHeader("Runtime/Mono/Awaitable.h")]
[Token(Token = "0x200012F")]
public class Awaitable : IEnumerator
{
	[CompilerGenerated]
	[Token(Token = "0x2000136")]
	private sealed class <>c
	{
		[Token(Token = "0x400053D")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400053E")]
		public static Func<Awaitable> <>9__76_1; //Field offset: 0x8

		[Address(RVA = "0x1977680", Offset = "0x1976880", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000907")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000908")]
		public <>c() { }

		[Address(RVA = "0x1977480", Offset = "0x1976680", Length = "0x148")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", "System.Action`1<T>", "System.Action`1<T>", typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000909")]
		internal ObjectPool<Awaitable> <.cctor>b__76_0() { }

		[Address(RVA = "0x19775D0", Offset = "0x19767D0", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600090A")]
		internal Awaitable <.cctor>b__76_1() { }

	}

	[Token(Token = "0x2000134")]
	private struct AwaitableAndFrameIndex
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000539")]
		private readonly Awaitable <Awaitable>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400053A")]
		private readonly int <FrameIndex>k__BackingField; //Field offset: 0x8

		[Token(Token = "0x17000180")]
		public Awaitable Awaitable
		{
			[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
			[CallerCount(Count = 140)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			[Token(Token = "0x6000902")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000181")]
		public int FrameIndex
		{
			[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
			[CallerCount(Count = 5)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			[Token(Token = "0x6000903")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000902")]
		public Awaitable get_Awaitable() { }

		[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000903")]
		public int get_FrameIndex() { }

	}

	[ExcludeFromDocs]
	[Token(Token = "0x2000131")]
	internal struct AwaitableAsyncMethodBuilder
	{
		[Token(Token = "0x2000132")]
		private interface IStateMachineBox : IDisposable
		{

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000534")]
		private IStateMachineBox _stateMachineBox; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000535")]
		private Awaitable _resultingCoroutine; //Field offset: 0x8

	}

	[IsReadOnly]
	[Token(Token = "0x2000133")]
	private struct AwaitableHandle
	{
		[Token(Token = "0x4000537")]
		public static AwaitableHandle ManagedHandle; //Field offset: 0x0
		[Token(Token = "0x4000538")]
		public static AwaitableHandle NullHandle; //Field offset: 0x8
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000536")]
		private readonly IntPtr _handle; //Field offset: 0x0

		[Token(Token = "0x1700017F")]
		public bool IsManaged
		{
			[Address(RVA = "0x195C1C0", Offset = "0x195B3C0", Length = "0x5A")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x60008FE")]
			 get { } //Length: 90
		}

		[Token(Token = "0x1700017E")]
		public bool IsNull
		{
			[Address(RVA = "0x9E2EA0", Offset = "0x9E20A0", Length = "0x8")]
			[CallerCount(Count = 8)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[Token(Token = "0x60008FD")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x195C150", Offset = "0x195B350", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(IntPtr), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000901")]
		private static AwaitableHandle() { }

		[Address(RVA = "0xC498F0", Offset = "0xC48AF0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008FF")]
		public AwaitableHandle(IntPtr handle) { }

		[Address(RVA = "0x195C1C0", Offset = "0x195B3C0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60008FE")]
		public bool get_IsManaged() { }

		[Address(RVA = "0x9E2EA0", Offset = "0x9E20A0", Length = "0x8")]
		[CallerCount(Count = 8)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x60008FD")]
		public bool get_IsNull() { }

		[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
		[CallerCount(Count = 2057)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000900")]
		public static IntPtr op_Implicit(AwaitableHandle handle) { }

	}

	[Token(Token = "0x2000130")]
	public enum AwaiterCompletionThreadAffinity
	{
		None = 0,
		MainThread = 1,
		BackgroundThread = 2,
	}

	[Token(Token = "0x2000135")]
	private class DoubleBufferedAwaitableList
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400053B")]
		private List<AwaitableAndFrameIndex> _awaitables; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400053C")]
		private List<AwaitableAndFrameIndex> _scratch; //Field offset: 0x18

		[Address(RVA = "0x195F4D0", Offset = "0x195E6D0", Length = "0xA5")]
		[CalledBy(Type = typeof(Awaitable), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x6000906")]
		public DoubleBufferedAwaitableList() { }

		[Address(RVA = "0x195F1D0", Offset = "0x195E3D0", Length = "0x5F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000905")]
		public void Clear() { }

		[Address(RVA = "0x195F230", Offset = "0x195E430", Length = "0x292")]
		[CalledBy(Type = typeof(Awaitable), Member = "OnUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Awaitable), Member = "OnEndOfFrame", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18195A360")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001ED30")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(Awaitable), Member = "get_IsDettachedOrCompleted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18195A0D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000904")]
		public void SwapAndComplete() { }

	}

	[Token(Token = "0x4000522")]
	private static readonly ThreadLocal<ObjectPool`1<Awaitable>> _pool; //Field offset: 0x0
	[Token(Token = "0x400052A")]
	private static bool _nextFrameAndEndOfFrameWiredUp; //Field offset: 0x8
	[Token(Token = "0x400052B")]
	private static CancellationTokenRegistration _nextFrameAndEndOfFrameWiredUpCTRegistration; //Field offset: 0x10
	[Token(Token = "0x400052C")]
	private static readonly DoubleBufferedAwaitableList _nextFrameAwaitables; //Field offset: 0x28
	[Token(Token = "0x400052D")]
	private static readonly DoubleBufferedAwaitableList _endOfFrameAwaitables; //Field offset: 0x30
	[Token(Token = "0x400052E")]
	private static SynchronizationContext _synchronizationContext; //Field offset: 0x38
	[Token(Token = "0x400052F")]
	private static int _mainThreadId; //Field offset: 0x40
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000521")]
	private SpinLock _spinLock; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000523")]
	private AwaitableHandle _handle; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000524")]
	private ExceptionDispatchInfo _exceptionToRethrow; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000525")]
	private bool _managedAwaitableDone; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000526")]
	private AwaiterCompletionThreadAffinity _completionThreadAffinity; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000527")]
	private Action _continuation; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000528")]
	private Nullable<CancellationTokenRegistration> _cancelTokenRegistration; //Field offset: 0x38
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000529")]
	private DoubleBufferedAwaitableList _managedCompletionQueue; //Field offset: 0x58

	[Token(Token = "0x1700017B")]
	public bool IsCompleted
	{
		[Address(RVA = "0x195D350", Offset = "0x195C550", Length = "0x1E3")]
		[CalledBy(Type = typeof(Awaitable), Member = "System.Collections.IEnumerator.MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18195A1F0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18195A290")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181959FF0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60008F2")]
		 get { } //Length: 483
	}

	[Token(Token = "0x1700017A")]
	private bool IsCompletedNoLock
	{
		[Address(RVA = "0x195D210", Offset = "0x195C410", Length = "0x13D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18195A1F0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18195A290")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60008F1")]
		private get { } //Length: 317
	}

	[Token(Token = "0x1700017C")]
	internal bool IsDettachedOrCompleted
	{
		[Address(RVA = "0x195D540", Offset = "0x195C740", Length = "0x1F6")]
		[CalledBy(Type = typeof(DoubleBufferedAwaitableList), Member = "SwapAndComplete", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18195A1F0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181959FF0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60008F3")]
		internal get { } //Length: 502
	}

	[Token(Token = "0x1700017D")]
	private override object System.Collections.IEnumerator.Current
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008F7")]
		private get { } //Length: 3
	}

	[Address(RVA = "0x195D030", Offset = "0x195C230", Length = "0x1C4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ThreadLocal`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DoubleBufferedAwaitableList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008FC")]
	private static Awaitable() { }

	[Address(RVA = "0x195D200", Offset = "0x195C400", Length = "0xC")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008EB")]
	private Awaitable() { }

	[Address(RVA = "0x195C220", Offset = "0x195B420", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60008F4")]
	private AwaitableHandle CheckPointerValidity() { }

	[Address(RVA = "0x195C2C0", Offset = "0x195B4C0", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60008EE")]
	private static void DoRunContinuationOnSynchonizationContext(object continuation) { }

	[Address(RVA = "0x195D350", Offset = "0x195C550", Length = "0x1E3")]
	[CalledBy(Type = typeof(Awaitable), Member = "System.Collections.IEnumerator.MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18195A1F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18195A290")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181959FF0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60008F2")]
	public bool get_IsCompleted() { }

	[Address(RVA = "0x195D210", Offset = "0x195C410", Length = "0x13D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18195A1F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18195A290")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60008F1")]
	private bool get_IsCompletedNoLock() { }

	[Address(RVA = "0x195D540", Offset = "0x195C740", Length = "0x1F6")]
	[CalledBy(Type = typeof(DoubleBufferedAwaitableList), Member = "SwapAndComplete", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18195A1F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181959FF0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60008F3")]
	internal bool get_IsDettachedOrCompleted() { }

	[Address(RVA = "0x195C320", Offset = "0x195B520", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("Scripting::Awaitables::IsCompleted", IsThreadSafe = True)]
	[Token(Token = "0x60008EA")]
	private static int IsNativeAwaitableCompleted(IntPtr nativeAwaitable) { }

	[Address(RVA = "0x195C360", Offset = "0x195B560", Length = "0xCD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60008EC")]
	private static bool MatchCompletionThreadAffinity(AwaiterCompletionThreadAffinity awaiterCompletionThreadAffinity) { }

	[Address(RVA = "0x195C430", Offset = "0x195B630", Length = "0x125")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[RequiredByNativeCode]
	[Token(Token = "0x60008F8")]
	private static void OnDelayedCallManagerCleared() { }

	[Address(RVA = "0x195C560", Offset = "0x195B760", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DoubleBufferedAwaitableList), Member = "SwapAndComplete", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[RequiredByNativeCode]
	[Token(Token = "0x60008FA")]
	private static void OnEndOfFrame() { }

	[Address(RVA = "0x195C5C0", Offset = "0x195B7C0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DoubleBufferedAwaitableList), Member = "SwapAndComplete", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[RequiredByNativeCode]
	[Token(Token = "0x60008F9")]
	private static void OnUpdate() { }

	[Address(RVA = "0x195C620", Offset = "0x195B820", Length = "0x470")]
	[CalledBy(Type = typeof(Awaitable), Member = "System.Collections.IEnumerator.MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CancellationTokenRegistration), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectPool`1), Member = "get_CountInactive", ReturnType = typeof(int))]
	[Calls(Type = typeof(ThreadLocal`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181959FF0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18195A1F0")]
	[Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60008F0")]
	internal void PropagateExceptionAndRelease() { }

	[Address(RVA = "0x195CAA0", Offset = "0x195BCA0", Length = "0x14A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181959FF0")]
	[Calls(Type = typeof(Awaitable), Member = "RunOrScheduleContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AwaiterCompletionThreadAffinity), typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x60008EF")]
	internal void RaiseManagedCompletion() { }

	[Address(RVA = "0x195CBF0", Offset = "0x195BDF0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("Scripting::Awaitables::Release", IsThreadSafe = True)]
	[Token(Token = "0x60008E9")]
	private static void ReleaseNativeAwaitable(IntPtr nativeAwaitable) { }

	[Address(RVA = "0x195CC30", Offset = "0x195BE30", Length = "0xF5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181959FF0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x60008E8")]
	private void RunContinuation() { }

	[Address(RVA = "0x195CD30", Offset = "0x195BF30", Length = "0x159")]
	[CalledBy(Type = typeof(Vector3), Member = "op_UnaryNegation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(Awaitable), Member = "RaiseManagedCompletion", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18195A290")]
	[Calls(Type = typeof(Task), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60008ED")]
	private void RunOrScheduleContinuation(AwaiterCompletionThreadAffinity awaiterCompletionThreadAffinity, Action continuation) { }

	[Address(RVA = "0x195CE90", Offset = "0x195C090", Length = "0xDF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181959FF0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x60008E7")]
	private void SetExceptionFromNative(Exception ex) { }

	[Address(RVA = "0x195CF70", Offset = "0x195C170", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60008FB")]
	internal static void SetSynchronizationContext(UnitySynchronizationContext synchronizationContext) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008F7")]
	private override object System.Collections.IEnumerator.get_Current() { }

	[Address(RVA = "0x195D000", Offset = "0x195C200", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Awaitable), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Awaitable), Member = "PropagateExceptionAndRelease", ReturnType = typeof(void))]
	[Token(Token = "0x60008F5")]
	private override bool System.Collections.IEnumerator.MoveNext() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008F6")]
	private override void System.Collections.IEnumerator.Reset() { }

}

