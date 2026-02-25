namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Geometry (7))]
[Token(Token = "0x20001E2")]
public class GeometryChangedEvent : EventBase<GeometryChangedEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x20001E3")]
	private sealed class <>c
	{
		[Token(Token = "0x400083F")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1C62510", Offset = "0x1C61710", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D8D")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D8E")]
		public <>c() { }

		[Address(RVA = "0x1C61140", Offset = "0x1C60340", Length = "0xB6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(EventBase`1), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6000D8F")]
		internal GeometryChangedEvent <.cctor>b__0_0() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400083C")]
	private Rect <oldRect>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400083D")]
	private Rect <newRect>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400083E")]
	private int <layoutPass>k__BackingField; //Field offset: 0x88

	[Token(Token = "0x17000263")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int layoutPass
	{
		[Address(RVA = "0x504490", Offset = "0x503690", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D8A")]
		internal get { } //Length: 7
		[Address(RVA = "0xE0C2B0", Offset = "0xE0B4B0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D8B")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000262")]
	public private Rect newRect
	{
		[Address(RVA = "0x96AA40", Offset = "0x969C40", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D88")]
		 get { } //Length: 11
		[Address(RVA = "0x96AC60", Offset = "0x969E60", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D89")]
		private set { } //Length: 8
	}

	[Token(Token = "0x17000261")]
	public private Rect oldRect
	{
		[Address(RVA = "0x3C1BC0", Offset = "0x3C0DC0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D86")]
		 get { } //Length: 11
		[Address(RVA = "0x504760", Offset = "0x503960", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D87")]
		private set { } //Length: 8
	}

	[Address(RVA = "0x1C53410", Offset = "0x1C52610", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EventBase`1), Member = "SetCreateFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D82")]
	private static GeometryChangedEvent() { }

	[Address(RVA = "0x1C534F0", Offset = "0x1C526F0", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000D8C")]
	public GeometryChangedEvent() { }

	[Address(RVA = "0x504490", Offset = "0x503690", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D8A")]
	internal int get_layoutPass() { }

	[Address(RVA = "0x96AA40", Offset = "0x969C40", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D88")]
	public Rect get_newRect() { }

	[Address(RVA = "0x3C1BC0", Offset = "0x3C0DC0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D86")]
	public Rect get_oldRect() { }

	[Address(RVA = "0x1C532E0", Offset = "0x1C524E0", Length = "0x7C")]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "DispatchChangeEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.ValueTuple`3<UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VisualElement>>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRLayoutUpdater), Member = "DispatchMissedHierarchyChangeEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D83")]
	public static GeometryChangedEvent GetPooled(Rect oldRect, Rect newRect) { }

	[Address(RVA = "0x1C53360", Offset = "0x1C52560", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EventBase`1), Member = "Init", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000D84")]
	protected virtual void Init() { }

	[Address(RVA = "0x1C533D0", Offset = "0x1C525D0", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000D85")]
	private void LocalInit() { }

	[Address(RVA = "0xE0C2B0", Offset = "0xE0B4B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D8B")]
	internal void set_layoutPass(int value) { }

	[Address(RVA = "0x96AC60", Offset = "0x969E60", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D89")]
	private void set_newRect(Rect value) { }

	[Address(RVA = "0x504760", Offset = "0x503960", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D87")]
	private void set_oldRect(Rect value) { }

}

