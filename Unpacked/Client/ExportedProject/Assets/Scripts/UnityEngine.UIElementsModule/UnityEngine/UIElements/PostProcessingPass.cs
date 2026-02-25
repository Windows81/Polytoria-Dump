namespace UnityEngine.UIElements;

[Token(Token = "0x2000248")]
internal struct PostProcessingPass
{
	[Token(Token = "0x200024A")]
	internal sealed class ComputeRequiredMarginsDelegate : MulticastDelegate
	{

		[Address(RVA = "0x1C49510", Offset = "0x1C48710", Length = "0xA6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000FB7")]
		public ComputeRequiredMarginsDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x1C49490", Offset = "0x1C48690", Length = "0x76")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000FB8")]
		public override PostProcessingMargins Invoke(FilterFunction func) { }

	}

	[Token(Token = "0x2000249")]
	internal sealed class PrepareMaterialPropertyBlockDelegate : MulticastDelegate
	{

		[Address(RVA = "0x1C5D150", Offset = "0x1C5C350", Length = "0xB5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000FB5")]
		public PrepareMaterialPropertyBlockDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x1C5D0E0", Offset = "0x1C5C2E0", Length = "0x63")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000FB6")]
		public override void Invoke(MaterialPropertyBlock mpb, FilterFunction func) { }

	}

	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40008D9")]
	private Material m_Material; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x40008DA")]
	private int m_PassIndex; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40008DB")]
	private ParameterBinding[] m_ParameterBindings; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40008DC")]
	private PostProcessingMargins m_ReadMargins; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40008DD")]
	private PostProcessingMargins m_WriteMargins; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008DE")]
	private PrepareMaterialPropertyBlockDelegate <prepareMaterialPropertyBlockCallback>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008DF")]
	private ComputeRequiredMarginsDelegate <computeRequiredReadMarginsCallback>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40008E0")]
	private ComputeRequiredMarginsDelegate <computeRequiredWriteMarginsCallback>k__BackingField; //Field offset: 0x48

	[Token(Token = "0x170002DD")]
	public ComputeRequiredMarginsDelegate computeRequiredReadMarginsCallback
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000FB1")]
		 get { } //Length: 5
		[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FB2")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002DE")]
	public ComputeRequiredMarginsDelegate computeRequiredWriteMarginsCallback
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000FB3")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FB4")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002D7")]
	public Material material
	{
		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FA5")]
		 get { } //Length: 4
		[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FA6")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170002D9")]
	public ParameterBinding[] parameterBindings
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FA9")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FAA")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002D8")]
	public int passIndex
	{
		[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FA7")]
		 get { } //Length: 4
		[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FA8")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170002DC")]
	public PrepareMaterialPropertyBlockDelegate prepareMaterialPropertyBlockCallback
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000FAF")]
		 get { } //Length: 5
		[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FB0")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002DA")]
	internal PostProcessingMargins readMargins
	{
		[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FAB")]
		internal get { } //Length: 11
		[Address(RVA = "0x5131E0", Offset = "0x5123E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FAC")]
		internal set { } //Length: 8
	}

	[Token(Token = "0x170002DB")]
	public PostProcessingMargins writeMargins
	{
		[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FAD")]
		 get { } //Length: 11
		[Address(RVA = "0x3B8870", Offset = "0x3B7A70", Length = "0x8")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FAE")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000FB1")]
	public ComputeRequiredMarginsDelegate get_computeRequiredReadMarginsCallback() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000FB3")]
	public ComputeRequiredMarginsDelegate get_computeRequiredWriteMarginsCallback() { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FA5")]
	public Material get_material() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FA9")]
	public ParameterBinding[] get_parameterBindings() { }

	[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FA7")]
	public int get_passIndex() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000FAF")]
	public PrepareMaterialPropertyBlockDelegate get_prepareMaterialPropertyBlockCallback() { }

	[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FAB")]
	internal PostProcessingMargins get_readMargins() { }

	[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FAD")]
	public PostProcessingMargins get_writeMargins() { }

	[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FB2")]
	public void set_computeRequiredReadMarginsCallback(ComputeRequiredMarginsDelegate value) { }

	[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FB4")]
	public void set_computeRequiredWriteMarginsCallback(ComputeRequiredMarginsDelegate value) { }

	[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FA6")]
	public void set_material(Material value) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FAA")]
	public void set_parameterBindings(ParameterBinding[] value) { }

	[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FA8")]
	public void set_passIndex(int value) { }

	[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FB0")]
	public void set_prepareMaterialPropertyBlockCallback(PrepareMaterialPropertyBlockDelegate value) { }

	[Address(RVA = "0x5131E0", Offset = "0x5123E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FAC")]
	internal void set_readMargins(PostProcessingMargins value) { }

	[Address(RVA = "0x3B8870", Offset = "0x3B7A70", Length = "0x8")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FAE")]
	public void set_writeMargins(PostProcessingMargins value) { }

}

