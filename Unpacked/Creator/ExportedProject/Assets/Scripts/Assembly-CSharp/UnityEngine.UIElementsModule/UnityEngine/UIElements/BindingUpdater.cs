namespace UnityEngine.UIElements;

[Token(Token = "0x2000022")]
internal class BindingUpdater
{
	[Token(Token = "0x2000023")]
	private sealed class CastDataSourceVisitor : ConcreteTypeVisitor
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000049")]
		private DataBinding <Binding>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400004A")]
		private BindingContext <bindingContext>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x150")]
		[Token(Token = "0x400004B")]
		private BindingResult <result>k__BackingField; //Field offset: 0x150

		[Token(Token = "0x17000023")]
		public DataBinding Binding
		{
			[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
			[CallerCount(Count = 50)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60000A4")]
			 get { } //Length: 5
			[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60000A5")]
			 set { } //Length: 13
		}

		[Token(Token = "0x17000024")]
		public BindingContext bindingContext
		{
			[Address(RVA = "0x1A97350", Offset = "0x1A96550", Length = "0x90")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[Token(Token = "0x60000A6")]
			 get { } //Length: 144
			[Address(RVA = "0x1A973E0", Offset = "0x1A965E0", Length = "0x8C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[Token(Token = "0x60000A7")]
			 set { } //Length: 140
		}

		[Token(Token = "0x17000025")]
		public BindingResult result
		{
			[Address(RVA = "0x18CE450", Offset = "0x18CD650", Length = "0xE")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60000A8")]
			 get { } //Length: 14
			[Address(RVA = "0x1A97470", Offset = "0x1A96670", Length = "0x18")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[Token(Token = "0x60000A9")]
			 set { } //Length: 24
		}

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000AC")]
		public CastDataSourceVisitor() { }

		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A4")]
		public DataBinding get_Binding() { }

		[Address(RVA = "0x1A97350", Offset = "0x1A96550", Length = "0x90")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60000A6")]
		public BindingContext get_bindingContext() { }

		[Address(RVA = "0x18CE450", Offset = "0x18CD650", Length = "0xE")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A8")]
		public BindingResult get_result() { }

		[Address(RVA = "0x1A97270", Offset = "0x1A96470", Length = "0xDC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
		[Token(Token = "0x60000AA")]
		public void Reset() { }

		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A5")]
		public void set_Binding(DataBinding value) { }

		[Address(RVA = "0x1A973E0", Offset = "0x1A965E0", Length = "0x8C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x60000A7")]
		public void set_bindingContext(BindingContext value) { }

		[Address(RVA = "0x1A97470", Offset = "0x1A96670", Length = "0x18")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x60000A9")]
		public void set_result(BindingResult value) { }

		[Address(RVA = "0x7CDA00", Offset = "0x7CCC00", Length = "0x129")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE450")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000AB")]
		protected virtual void VisitContainer(ref TContainer container) { }

	}

	[Token(Token = "0x2000024")]
	private sealed class UIPathVisitor : PathVisitor
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x400004C")]
		private DataBinding <binding>k__BackingField; //Field offset: 0xB8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x400004D")]
		private BindingUpdateStage <direction>k__BackingField; //Field offset: 0xC0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x400004E")]
		private BindingContext <bindingContext>k__BackingField; //Field offset: 0xC8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x200")]
		[Token(Token = "0x400004F")]
		private BindingResult <result>k__BackingField; //Field offset: 0x200

		[Token(Token = "0x17000026")]
		public DataBinding binding
		{
			[Address(RVA = "0x2DD1E0", Offset = "0x2DC3E0", Length = "0x8")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60000AD")]
			 get { } //Length: 8
			[Address(RVA = "0x2DD4D0", Offset = "0x2DC6D0", Length = "0x13")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60000AE")]
			 set { } //Length: 19
		}

		[Token(Token = "0x17000028")]
		public BindingContext bindingContext
		{
			[Address(RVA = "0x1AB7240", Offset = "0x1AB6440", Length = "0x92")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[Token(Token = "0x60000B1")]
			 get { } //Length: 146
			[Address(RVA = "0x1AB72E0", Offset = "0x1AB64E0", Length = "0x8F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[Token(Token = "0x60000B2")]
			 set { } //Length: 143
		}

		[Token(Token = "0x17000027")]
		public BindingUpdateStage direction
		{
			[Address(RVA = "0x3D6650", Offset = "0x3D5850", Length = "0x7")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60000AF")]
			 get { } //Length: 7
			[Address(RVA = "0x1AB7370", Offset = "0x1AB6570", Length = "0x7")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[Token(Token = "0x60000B0")]
			 set { } //Length: 7
		}

		[Token(Token = "0x17000029")]
		public BindingResult result
		{
			[Address(RVA = "0x1551D70", Offset = "0x1550F70", Length = "0xE")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x60000B3")]
			 get { } //Length: 14
			[Address(RVA = "0x1AB7380", Offset = "0x1AB6580", Length = "0x18")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[Token(Token = "0x60000B4")]
			 set { } //Length: 24
		}

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B7")]
		public UIPathVisitor() { }

		[Address(RVA = "0x2DD1E0", Offset = "0x2DC3E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000AD")]
		public DataBinding get_binding() { }

		[Address(RVA = "0x1AB7240", Offset = "0x1AB6440", Length = "0x92")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60000B1")]
		public BindingContext get_bindingContext() { }

		[Address(RVA = "0x3D6650", Offset = "0x3D5850", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000AF")]
		public BindingUpdateStage get_direction() { }

		[Address(RVA = "0x1551D70", Offset = "0x1550F70", Length = "0xE")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B3")]
		public BindingResult get_result() { }

		[Address(RVA = "0x1AB7130", Offset = "0x1AB6330", Length = "0x107")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PathVisitor), Member = "Reset", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
		[Token(Token = "0x60000B5")]
		public virtual void Reset() { }

		[Address(RVA = "0x2DD4D0", Offset = "0x2DC6D0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000AE")]
		public void set_binding(DataBinding value) { }

		[Address(RVA = "0x1AB72E0", Offset = "0x1AB64E0", Length = "0x8F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x60000B2")]
		public void set_bindingContext(BindingContext value) { }

		[Address(RVA = "0x1AB7370", Offset = "0x1AB6570", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60000B0")]
		public void set_direction(BindingUpdateStage value) { }

		[Address(RVA = "0x1AB7380", Offset = "0x1AB6580", Length = "0x18")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x60000B4")]
		public void set_result(BindingResult value) { }

		[Address(RVA = "0x7CFFD0", Offset = "0x7CF1D0", Length = "0x23C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE450")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B6")]
		protected virtual void VisitPath(Property<TContainer, TValue> property, ref TContainer container, ref TValue value) { }

	}

	[Token(Token = "0x4000047")]
	private static readonly CastDataSourceVisitor s_VisitDataSourceAsRootVisitor; //Field offset: 0x0
	[Token(Token = "0x4000048")]
	private static readonly UIPathVisitor s_VisitDataSourceAtPathVisitor; //Field offset: 0x8

	[Address(RVA = "0x1A96E70", Offset = "0x1A96070", Length = "0xC4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60000A3")]
	private static BindingUpdater() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A2")]
	public BindingUpdater() { }

	[Address(RVA = "0x1A94860", Offset = "0x1A93A60", Length = "0x218")]
	[CalledBy(Type = typeof(BindingUpdater), Member = "UpdateUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(DataBinding)}, ReturnType = typeof(BindingResult))]
	[CalledBy(Type = typeof(BindingUpdater), Member = "UpdateDataSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(DataBinding)}, ReturnType = typeof(BindingResult))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000A0")]
	internal static string GetExtractValueErrorString(VisitReturnCode returnCode, object target, in PropertyPath path) { }

	[Address(RVA = "0x1A94AA0", Offset = "0x1A93CA0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000A1")]
	internal static string GetRootDataSourceError(object target) { }

	[Address(RVA = "0x1A94B20", Offset = "0x1A93D20", Length = "0x228")]
	[CalledBy(Type = typeof(BindingUpdater), Member = "UpdateUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(DataBinding)}, ReturnType = typeof(BindingResult))]
	[CalledBy(Type = typeof(BindingUpdater), Member = "UpdateDataSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(DataBinding)}, ReturnType = typeof(BindingResult))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600009F")]
	internal static string GetVisitationErrorString(VisitReturnCode returnCode, in BindingContext context) { }

	[Address(RVA = "0x1A94D70", Offset = "0x1A93F70", Length = "0x32D")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessPropertyChangedEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.Binding>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TypeUtility), Member = "GetTypeDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Token(Token = "0x6000093")]
	public bool ShouldProcessBindingAtStage(Binding bindingObject, BindingUpdateStage stage, bool versionChanged, bool dirty) { }

	[Address(RVA = "0x1A951B0", Offset = "0x1A943B0", Length = "0xD3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000095")]
	private bool ShouldProcessBindingAtStage(CustomBinding customBinding, BindingUpdateStage stage, bool versionChanged, bool dirty) { }

	[Address(RVA = "0x1A950A0", Offset = "0x1A942A0", Length = "0x104")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000094")]
	private static bool ShouldProcessBindingAtStage(DataBinding dataBinding, BindingUpdateStage stage, bool versionChanged, bool dirty) { }

	[Address(RVA = "0x1A95290", Offset = "0x1A94490", Length = "0xA28")]
	[CalledBy(Type = typeof(BindingUpdater), Member = "UpdateUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(DataBinding)}, ReturnType = typeof(BindingResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(DataBinding), Member = "get_updateUIMethod", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE450")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 16)]
	[Token(Token = "0x600009C")]
	private static BindingResult TryUpdateUIWithNonContainer(in BindingContext context, DataBinding binding, object value) { }

	[Address(RVA = "0x1A95D40", Offset = "0x1A94F40", Length = "0x555")]
	[CalledBy(Type = typeof(BindingUpdater), Member = "UpdateSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(Binding)}, ReturnType = typeof(BindingResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BindingUpdater), Member = "GetExtractValueErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisitReturnCode), typeof(object), typeof(PropertyPath&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PropertyPath), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingUpdater), Member = "VisitAtPath", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataBinding), typeof(BindingUpdateStage), "TContainer&", typeof(PropertyPath&), typeof(BindingContext&)}, ReturnType = typeof(System.ValueTuple`4<System.Boolean, Unity.Properties.VisitReturnCode, Unity.Properties.VisitReturnCode, UnityEngine.UIElements.BindingResult>))]
	[Calls(Type = typeof(BindingUpdater), Member = "GetVisitationErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisitReturnCode), typeof(BindingContext&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeUtility), Member = "GetTypeDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600009A")]
	private BindingResult UpdateDataSource(in BindingContext context, DataBinding dataBinding) { }

	[Address(RVA = "0x1A95D00", Offset = "0x1A94F00", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600009B")]
	private BindingResult UpdateDataSource(in BindingContext context, CustomBinding customBinding) { }

	[Address(RVA = "0x1A962A0", Offset = "0x1A954A0", Length = "0x1A6")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessPropertyChangedEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.Binding>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BindingUpdater), Member = "UpdateDataSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(DataBinding)}, ReturnType = typeof(BindingResult))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(TypeUtility), Member = "GetTypeDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000097")]
	public BindingResult UpdateSource(in BindingContext context, Binding bindingObject) { }

	[Address(RVA = "0x1A96450", Offset = "0x1A95650", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000099")]
	private BindingResult UpdateUI(in BindingContext context, CustomBinding customBinding) { }

	[Address(RVA = "0x1A96930", Offset = "0x1A95B30", Length = "0x1A2")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "ProcessPropertyChangedEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.HashSet`1<UnityEngine.UIElements.Binding>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BindingUpdater), Member = "UpdateUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(DataBinding)}, ReturnType = typeof(BindingResult))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(TypeUtility), Member = "GetTypeDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000096")]
	public BindingResult UpdateUI(in BindingContext context, Binding bindingObject) { }

	[Address(RVA = "0x1A964A0", Offset = "0x1A956A0", Length = "0x48B")]
	[CalledBy(Type = typeof(BindingUpdater), Member = "UpdateUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(Binding)}, ReturnType = typeof(BindingResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BindingUpdater), Member = "GetVisitationErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisitReturnCode), typeof(BindingContext&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TypeUtility), Member = "GetTypeDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BindingUpdater), Member = "TryUpdateUIWithNonContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(DataBinding), typeof(object)}, ReturnType = typeof(BindingResult))]
	[Calls(Type = typeof(BindingUpdater), Member = "VisitRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataBinding), typeof(Object&), typeof(BindingContext&)}, ReturnType = typeof(System.ValueTuple`3<System.Boolean, Unity.Properties.VisitReturnCode, UnityEngine.UIElements.BindingResult>))]
	[Calls(Type = typeof(TypeTraits), Member = "IsContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(BindingUpdater), Member = "GetExtractValueErrorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisitReturnCode), typeof(object), typeof(PropertyPath&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(BindingUpdater), Member = "VisitAtPath", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataBinding), typeof(BindingUpdateStage), "TContainer&", typeof(PropertyPath&), typeof(BindingContext&)}, ReturnType = typeof(System.ValueTuple`4<System.Boolean, Unity.Properties.VisitReturnCode, Unity.Properties.VisitReturnCode, UnityEngine.UIElements.BindingResult>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PropertyPath), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000098")]
	private BindingResult UpdateUI(in BindingContext context, DataBinding dataBinding) { }

	[Address(RVA = "0x683880", Offset = "0x682A80", Length = "0x3C6")]
	[CalledBy(Type = typeof(BindingUpdater), Member = "UpdateUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(DataBinding)}, ReturnType = typeof(BindingResult))]
	[CalledBy(Type = typeof(BindingUpdater), Member = "UpdateDataSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(DataBinding)}, ReturnType = typeof(BindingResult))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PropertyContainer), Member = "TryAccept", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPropertyBagVisitor), typeof(Object&), typeof(VisitReturnCode&), typeof(VisitParameters)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.ValueTuple`4<System.Boolean, System.Int32Enum, System.Int32Enum, UnityEngine.UIElements.BindingResult>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Int32Enum", "System.Int32Enum", typeof(BindingResult)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600009E")]
	private static ValueTuple<Boolean, VisitReturnCode, VisitReturnCode, BindingResult> VisitAtPath(DataBinding dataBinding, BindingUpdateStage direction, ref TContainer container, in PropertyPath path, in BindingContext context) { }

	[Address(RVA = "0x1A96AE0", Offset = "0x1A95CE0", Length = "0x386")]
	[CalledBy(Type = typeof(BindingUpdater), Member = "UpdateUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingContext&), typeof(DataBinding)}, ReturnType = typeof(BindingResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(PropertyContainer), Member = "TryAccept", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPropertyBagVisitor), typeof(Object&), typeof(VisitReturnCode&), typeof(VisitParameters)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ValueTuple`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600009D")]
	private static ValueTuple<Boolean, VisitReturnCode, BindingResult> VisitRoot(DataBinding dataBinding, ref object container, in BindingContext context) { }

}

