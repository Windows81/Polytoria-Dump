namespace RLD;

[Token(Token = "0x200022E")]
public class ObjectGrabSettings : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000884")]
	private bool _alignAxis; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x4000885")]
	private TransformAxis _alignmentAxis; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000886")]
	private float _rotationSensitivity; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x4000887")]
	private float _scaleSensitivity; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000888")]
	private float _offsetFromSurfaceSensitivity; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x4000889")]
	private float _offsetFromAnchorSensitivity; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400088A")]
	private ObjectGrabSurfaceFlags _surfaceFlags; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x400088B")]
	private float _defaultOffsetFromSurface; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x400088C")]
	private int _surfaceLayers; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x400088D")]
	private ObjectLayerGrabSettings[] _layerGrabSettings; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x400088E")]
	private int _sphericalMeshLayers; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[Token(Token = "0x400088F")]
	private int _terrainMeshLayers; //Field offset: 0x5C

	[Token(Token = "0x170006A6")]
	public bool AlignAxis
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014F0")]
		 get { } //Length: 5
		[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014F1")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170006A7")]
	public TransformAxis AlignmentAxis
	{
		[Address(RVA = "0x3095F0", Offset = "0x3087F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014F2")]
		 get { } //Length: 4
		[Address(RVA = "0x309650", Offset = "0x308850", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014F3")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170006AD")]
	public float DefaultOffsetFromSurface
	{
		[Address(RVA = "0x3B43C0", Offset = "0x3B35C0", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014FE")]
		 get { } //Length: 6
		[Address(RVA = "0x599380", Offset = "0x598580", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014FF")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170006AB")]
	public float OffsetFromAnchorSensitivity
	{
		[Address(RVA = "0x3B4320", Offset = "0x3B3520", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014FA")]
		 get { } //Length: 6
		[Address(RVA = "0x599390", Offset = "0x598590", Length = "0x26")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60014FB")]
		 set { } //Length: 38
	}

	[Token(Token = "0x170006AA")]
	public float OffsetFromSurfaceSensitivity
	{
		[Address(RVA = "0x3B4330", Offset = "0x3B3530", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014F8")]
		 get { } //Length: 6
		[Address(RVA = "0x5993C0", Offset = "0x5985C0", Length = "0x26")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60014F9")]
		 set { } //Length: 38
	}

	[Token(Token = "0x170006A8")]
	public float RotationSensitivity
	{
		[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014F4")]
		 get { } //Length: 6
		[Address(RVA = "0x3EAB80", Offset = "0x3E9D80", Length = "0x26")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014F5")]
		 set { } //Length: 38
	}

	[Token(Token = "0x170006A9")]
	public float ScaleSensitivity
	{
		[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014F6")]
		 get { } //Length: 6
		[Address(RVA = "0x5993F0", Offset = "0x5985F0", Length = "0x26")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60014F7")]
		 set { } //Length: 38
	}

	[Token(Token = "0x170006AF")]
	public int SphericalMeshLayers
	{
		[Address(RVA = "0x406220", Offset = "0x405420", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001502")]
		 get { } //Length: 4
		[Address(RVA = "0x599420", Offset = "0x598620", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001503")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170006AC")]
	public ObjectGrabSurfaceFlags SurfaceFlags
	{
		[Address(RVA = "0x324350", Offset = "0x323550", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014FC")]
		 get { } //Length: 4
		[Address(RVA = "0x324370", Offset = "0x323570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60014FD")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170006AE")]
	public int SurfaceLayers
	{
		[Address(RVA = "0x309620", Offset = "0x308820", Length = "0x4")]
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001500")]
		 get { } //Length: 4
		[Address(RVA = "0x309680", Offset = "0x308880", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001501")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170006B0")]
	public int TerrainMeshLayers
	{
		[Address(RVA = "0x53C080", Offset = "0x53B280", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001504")]
		 get { } //Length: 4
		[Address(RVA = "0x599430", Offset = "0x598630", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001505")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x599210", Offset = "0x598410", Length = "0x16D")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001506")]
	public ObjectGrabSettings() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014F0")]
	public bool get_AlignAxis() { }

	[Address(RVA = "0x3095F0", Offset = "0x3087F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014F2")]
	public TransformAxis get_AlignmentAxis() { }

	[Address(RVA = "0x3B43C0", Offset = "0x3B35C0", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014FE")]
	public float get_DefaultOffsetFromSurface() { }

	[Address(RVA = "0x3B4320", Offset = "0x3B3520", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014FA")]
	public float get_OffsetFromAnchorSensitivity() { }

	[Address(RVA = "0x3B4330", Offset = "0x3B3530", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014F8")]
	public float get_OffsetFromSurfaceSensitivity() { }

	[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014F4")]
	public float get_RotationSensitivity() { }

	[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014F6")]
	public float get_ScaleSensitivity() { }

	[Address(RVA = "0x406220", Offset = "0x405420", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001502")]
	public int get_SphericalMeshLayers() { }

	[Address(RVA = "0x324350", Offset = "0x323550", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014FC")]
	public ObjectGrabSurfaceFlags get_SurfaceFlags() { }

	[Address(RVA = "0x309620", Offset = "0x308820", Length = "0x4")]
	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001500")]
	public int get_SurfaceLayers() { }

	[Address(RVA = "0x53C080", Offset = "0x53B280", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001504")]
	public int get_TerrainMeshLayers() { }

	[Address(RVA = "0x5991E0", Offset = "0x5983E0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001507")]
	public ObjectLayerGrabSettings GetLayerGrabSettings(int layer) { }

	[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014F1")]
	public void set_AlignAxis(bool value) { }

	[Address(RVA = "0x309650", Offset = "0x308850", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014F3")]
	public void set_AlignmentAxis(TransformAxis value) { }

	[Address(RVA = "0x599380", Offset = "0x598580", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014FF")]
	public void set_DefaultOffsetFromSurface(float value) { }

	[Address(RVA = "0x599390", Offset = "0x598590", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60014FB")]
	public void set_OffsetFromAnchorSensitivity(float value) { }

	[Address(RVA = "0x5993C0", Offset = "0x5985C0", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60014F9")]
	public void set_OffsetFromSurfaceSensitivity(float value) { }

	[Address(RVA = "0x3EAB80", Offset = "0x3E9D80", Length = "0x26")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014F5")]
	public void set_RotationSensitivity(float value) { }

	[Address(RVA = "0x5993F0", Offset = "0x5985F0", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60014F7")]
	public void set_ScaleSensitivity(float value) { }

	[Address(RVA = "0x599420", Offset = "0x598620", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001503")]
	public void set_SphericalMeshLayers(int value) { }

	[Address(RVA = "0x324370", Offset = "0x323570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014FD")]
	public void set_SurfaceFlags(ObjectGrabSurfaceFlags value) { }

	[Address(RVA = "0x309680", Offset = "0x308880", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001501")]
	public void set_SurfaceLayers(int value) { }

	[Address(RVA = "0x599430", Offset = "0x598630", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001505")]
	public void set_TerrainMeshLayers(int value) { }

}

