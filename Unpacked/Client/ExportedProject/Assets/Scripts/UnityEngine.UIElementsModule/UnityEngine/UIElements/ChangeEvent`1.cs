namespace UnityEngine.UIElements;

[EventCategory(EventCategory::ChangeValue (9))]
[Token(Token = "0x20001B2")]
public class ChangeEvent : EventBase<ChangeEvent`1<T>>
{
	[CompilerGenerated]
	[Token(Token = "0x20001B3")]
	private sealed class <>c
	{
		[Token(Token = "0x40007D7")]
		public static readonly <>c<T> <>9; //Field offset: 0x0

		[Address(RVA = "0x7FC210", Offset = "0x7FB410", Length = "0xE9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C58")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C59")]
		public <>c() { }

		[Address(RVA = "0x7F95B0", Offset = "0x7F87B0", Length = "0x5D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ChangeEvent`1), Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C5A")]
		internal ChangeEvent<T> <.cctor>b__0_0() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007D5")]
	private T <previousValue>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007D6")]
	private T <newValue>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x1700022F")]
	public T newValue
	{
		[Address(RVA = "0x5073E0", Offset = "0x5065E0", Length = "0x5")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C52")]
		 get { } //Length: 5
		[Address(RVA = "0x96AC90", Offset = "0x969E90", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C53")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700022E")]
	public T previousValue
	{
		[Address(RVA = "0x3BAA60", Offset = "0x3B9C60", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C50")]
		 get { } //Length: 5
		[Address(RVA = "0x3BAC60", Offset = "0x3B9E60", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C51")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x96A1A0", Offset = "0x9693A0", Length = "0x19C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EventBase`1), Member = "SetCreateFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C4F")]
	private static ChangeEvent`1() { }

	[Address(RVA = "0x96A900", Offset = "0x969B00", Length = "0x7A")]
	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__0_0", ReturnType = "UnityEngine.UIElements.ChangeEvent`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C57")]
	public ChangeEvent`1() { }

	[Address(RVA = "0x5073E0", Offset = "0x5065E0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C52")]
	public T get_newValue() { }

	[Address(RVA = "0x3BAA60", Offset = "0x3B9C60", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C50")]
	public T get_previousValue() { }

	[Address(RVA = "0x968EA0", Offset = "0x9680A0", Length = "0xD5")]
	[CalledBy(Type = typeof(Foldout), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseField`1), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValueType"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseField`1), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C56")]
	public static ChangeEvent<T> GetPooled(T previousValue, T newValue) { }

	[Address(RVA = "0x969BE0", Offset = "0x968DE0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventBase`1), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C54")]
	protected virtual void Init() { }

	[Address(RVA = "0x969F30", Offset = "0x969130", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C55")]
	private void LocalInit() { }

	[Address(RVA = "0x96AC90", Offset = "0x969E90", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C53")]
	protected void set_newValue(T value) { }

	[Address(RVA = "0x3BAC60", Offset = "0x3B9E60", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C51")]
	protected void set_previousValue(T value) { }

}

