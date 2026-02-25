namespace UnityEngine.UIElements;

[Token(Token = "0x2000510")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class PropertyChangedEvent : EventBase<PropertyChangedEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x2000511")]
	private sealed class <>c
	{
		[Token(Token = "0x40010C4")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1B67A80", Offset = "0x1B66C80", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002515")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002516")]
		public <>c() { }

		[Address(RVA = "0x1B67880", Offset = "0x1B66A80", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(EventBase`1), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6002517")]
		internal PropertyChangedEvent <.cctor>b__0_0() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40010C3")]
	private BindingId <property>k__BackingField; //Field offset: 0x68

	[Token(Token = "0x170009AB")]
	public BindingId property
	{
		[Address(RVA = "0x1B66C40", Offset = "0x1B65E40", Length = "0x73")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6002511")]
		 get { } //Length: 115
		[Address(RVA = "0x1B66CC0", Offset = "0x1B65EC0", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x6002512")]
		 set { } //Length: 122
	}

	[Address(RVA = "0x1B66AE0", Offset = "0x1B65CE0", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EventBase`1), Member = "SetCreateFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002510")]
	private static PropertyChangedEvent() { }

	[Address(RVA = "0x1B66BC0", Offset = "0x1B65DC0", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002513")]
	public PropertyChangedEvent() { }

	[Address(RVA = "0x1B66C40", Offset = "0x1B65E40", Length = "0x73")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6002511")]
	public BindingId get_property() { }

	[Address(RVA = "0x1B669C0", Offset = "0x1B65BC0", Length = "0x11F")]
	[CalledBy(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002514")]
	public static PropertyChangedEvent GetPooled(in BindingId property) { }

	[Address(RVA = "0x1B66CC0", Offset = "0x1B65EC0", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x6002512")]
	public void set_property(BindingId value) { }

}

