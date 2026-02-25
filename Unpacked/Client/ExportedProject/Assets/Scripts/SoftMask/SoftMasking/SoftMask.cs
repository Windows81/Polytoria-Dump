namespace SoftMasking;

[AddComponentMenu("UI/Soft Mask", 14)]
[DisallowMultipleComponent]
[ExecuteInEditMode]
[HelpURL("https://docs.google.com/document/d/1xsRItl0KqmB2jGwnB2xSktwSRrXrYEwQNWIErLLjG6Q")]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x200000F")]
public class SoftMask : UIBehaviour, ISoftMask, ICanvasRaycastFilter
{
	[CompilerGenerated]
	[Token(Token = "0x200001D")]
	private sealed class <>c
	{
		[Token(Token = "0x400006D")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400006E")]
		public static Action<SoftMaskable> <>9__101_0; //Field offset: 0x8
		[Token(Token = "0x400006F")]
		public static Action<SoftMaskable> <>9__102_0; //Field offset: 0x10

		[Address(RVA = "0x156A020", Offset = "0x1569220", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000AC")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000AD")]
		public <>c() { }

		[Address(RVA = "0x1569F10", Offset = "0x1569110", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SoftMaskable), Member = "Invalidate", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000AE")]
		internal void <InvalidateChildren>b__101_0(SoftMaskable x) { }

		[Address(RVA = "0x1569F30", Offset = "0x1569130", Length = "0x36")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SoftMaskable), Member = "FindMaskOrDie", ReturnType = typeof(bool))]
		[Calls(Type = typeof(SoftMaskable), Member = "Invalidate", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000AF")]
		internal void <NotifyChildrenThatMaskMightChanged>b__102_0(SoftMaskable x) { }

	}

	[Token(Token = "0x2000011")]
	internal enum BorderMode
	{
		Simple = 0,
		Sliced = 1,
		Tiled = 2,
	}

	[Token(Token = "0x2000019")]
	private struct Diagnostics
	{
		[CompilerGenerated]
		[Token(Token = "0x200001A")]
		private sealed class <>c__DisplayClass10_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000066")]
			public SoftMask softMask; //Field offset: 0x10

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60000A3")]
			public <>c__DisplayClass10_0() { }

			[Address(RVA = "0x1569F70", Offset = "0x1569170", Length = "0xC")]
			[CallerCount(Count = 0)]
			[Calls(Type = "SoftMasking.SoftMask+Diagnostics", Member = "AreCompeting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoftMask), typeof(SoftMask)}, ReturnType = typeof(bool))]
			[DeduplicatedMethod]
			[Token(Token = "0x60000A4")]
			internal bool <ThereAreNestedMasks>b__0(SoftMask x) { }

			[Address(RVA = "0x1569F70", Offset = "0x1569170", Length = "0xC")]
			[CallerCount(Count = 0)]
			[Calls(Type = "SoftMasking.SoftMask+Diagnostics", Member = "AreCompeting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoftMask), typeof(SoftMask)}, ReturnType = typeof(bool))]
			[DeduplicatedMethod]
			[Token(Token = "0x60000A5")]
			internal bool <ThereAreNestedMasks>b__1(SoftMask x) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x200001B")]
		private sealed class <>c__DisplayClass2_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000067")]
			public SoftMask softMask; //Field offset: 0x10

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60000A6")]
			public <>c__DisplayClass2_0() { }

			[Address(RVA = "0x1569F80", Offset = "0x1569180", Length = "0x28")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x60000A7")]
			internal bool <PollErrors>b__0(SoftMaskable m) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000065")]
		private SoftMask _softMask; //Field offset: 0x0

		[Token(Token = "0x1700001E")]
		private Image image
		{
			[Address(RVA = "0x1561FA0", Offset = "0x15611A0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(SoftMask), Member = "DeduceSourceParameters", ReturnType = "SoftMasking.SoftMask+SourceParameters")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x600009A")]
			private get { } //Length: 44
		}

		[Token(Token = "0x1700001F")]
		private Sprite sprite
		{
			[Address(RVA = "0x1561FD0", Offset = "0x15611D0", Length = "0x2D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(SoftMask), Member = "DeduceSourceParameters", ReturnType = "SoftMasking.SoftMask+SourceParameters")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x600009B")]
			private get { } //Length: 45
		}

		[Token(Token = "0x17000020")]
		private Texture texture
		{
			[Address(RVA = "0x1562000", Offset = "0x1561200", Length = "0x2D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(SoftMask), Member = "DeduceSourceParameters", ReturnType = "SoftMasking.SoftMask+SourceParameters")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x600009C")]
			private get { } //Length: 45
		}

		[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000097")]
		public Diagnostics(SoftMask softMask) { }

		[Address(RVA = "0x15615A0", Offset = "0x15607A0", Length = "0x1A6")]
		[CalledBy(Type = "SoftMasking.SoftMask+Diagnostics+<>c__DisplayClass10_0", Member = "<ThereAreNestedMasks>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoftMask)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "SoftMasking.SoftMask+Diagnostics+<>c__DisplayClass10_0", Member = "<ThereAreNestedMasks>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoftMask)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Diagnostics), Member = "SelectChild", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = "T")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Canvas), Member = "get_rootCanvas", ReturnType = typeof(Canvas))]
		[Calls(Type = typeof(SoftMask), Member = "get_isMaskingEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Canvas), Member = "get_overrideSorting", ReturnType = typeof(bool))]
		[Calls(Type = typeof(SoftMask), Member = "get_canvas", ReturnType = typeof(Canvas))]
		[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Token(Token = "0x60000A0")]
		private static bool AreCompeting(SoftMask softMask, SoftMask other) { }

		[Address(RVA = "0x1561750", Offset = "0x1560950", Length = "0xFD")]
		[CalledBy(Type = typeof(Diagnostics), Member = "PollErrors", ReturnType = typeof(Errors))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SoftMask), Member = "DeduceSourceParameters", ReturnType = "SoftMasking.SoftMask+SourceParameters")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600009E")]
		private Errors CheckImage() { }

		[Address(RVA = "0x1561850", Offset = "0x1560A50", Length = "0xC9")]
		[CalledBy(Type = typeof(Diagnostics), Member = "PollErrors", ReturnType = typeof(Errors))]
		[CalledBy(Type = typeof(SoftMask), Member = "UpdateMaskParameters", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMask), Member = "CalculateMaskParameters", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Sprite), Member = "get_packed", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Sprite), Member = "get_associatedAlphaSplitTexture", ReturnType = typeof(Texture2D))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000099")]
		public static Errors CheckSprite(Sprite sprite) { }

		[Address(RVA = "0x1561920", Offset = "0x1560B20", Length = "0x140")]
		[CalledBy(Type = typeof(Diagnostics), Member = "PollErrors", ReturnType = typeof(Errors))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SoftMask), Member = "DeduceSourceParameters", ReturnType = "SoftMasking.SoftMask+SourceParameters")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Diagnostics), Member = "IsReadable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600009F")]
		private Errors CheckTexture() { }

		[Address(RVA = "0x1561FA0", Offset = "0x15611A0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SoftMask), Member = "DeduceSourceParameters", ReturnType = "SoftMasking.SoftMask+SourceParameters")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600009A")]
		private Image get_image() { }

		[Address(RVA = "0x1561FD0", Offset = "0x15611D0", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SoftMask), Member = "DeduceSourceParameters", ReturnType = "SoftMasking.SoftMask+SourceParameters")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600009B")]
		private Sprite get_sprite() { }

		[Address(RVA = "0x1562000", Offset = "0x1561200", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SoftMask), Member = "DeduceSourceParameters", ReturnType = "SoftMasking.SoftMask+SourceParameters")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600009C")]
		private Texture get_texture() { }

		[Address(RVA = "0x1561A70", Offset = "0x1560C70", Length = "0x36")]
		[CalledBy(Type = typeof(Diagnostics), Member = "CheckTexture", ReturnType = typeof(Errors))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Texture2D), Member = "GetPixel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Color))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000A2")]
		private static bool IsReadable(Texture2D texture) { }

		[Address(RVA = "0x1561AB0", Offset = "0x1560CB0", Length = "0x25C")]
		[CalledBy(Type = typeof(SoftMask), Member = "PollErrors", ReturnType = typeof(Errors))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Diagnostics), Member = "CheckImage", ReturnType = typeof(Errors))]
		[Calls(Type = typeof(Diagnostics), Member = "CheckSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Errors))]
		[Calls(Type = typeof(SoftMask), Member = "DeduceSourceParameters", ReturnType = "SoftMasking.SoftMask+SourceParameters")]
		[Calls(Type = typeof(Diagnostics), Member = "ThereAreNestedMasks", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ClearListAtExit`1), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Diagnostics), Member = "CheckTexture", ReturnType = typeof(Errors))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000098")]
		public Errors PollErrors() { }

		[Address(RVA = "0x7CDB30", Offset = "0x7CCD30", Length = "0x64")]
		[CalledBy(Type = typeof(Diagnostics), Member = "AreCompeting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoftMask), typeof(SoftMask)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "IsChildOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A1")]
		private static T SelectChild(T first, T second) { }

		[Address(RVA = "0x1561D10", Offset = "0x1560F10", Length = "0x288")]
		[CalledBy(Type = typeof(Diagnostics), Member = "PollErrors", ReturnType = typeof(Errors))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Component), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ClearListAtExit`1), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600009D")]
		private bool ThereAreNestedMasks() { }

	}

	[Flags]
	[Token(Token = "0x2000012")]
	internal enum Errors
	{
		NoError = 0,
		UnsupportedShaders = 1,
		NestedMasks = 2,
		TightPackedSprite = 4,
		AlphaSplitSprite = 8,
		UnsupportedImageType = 16,
		UnreadableTexture = 32,
		UnreadableRenderTexture = 64,
	}

	[Token(Token = "0x2000010")]
	internal enum MaskSource
	{
		Graphic = 0,
		Sprite = 1,
		Texture = 2,
	}

	[Token(Token = "0x2000016")]
	private struct MaterialParameters
	{
		[Token(Token = "0x2000018")]
		private static class Ids
		{
			[Token(Token = "0x400005B")]
			public static readonly int SoftMask; //Field offset: 0x0
			[Token(Token = "0x400005C")]
			public static readonly int SoftMask_Rect; //Field offset: 0x4
			[Token(Token = "0x400005D")]
			public static readonly int SoftMask_UVRect; //Field offset: 0x8
			[Token(Token = "0x400005E")]
			public static readonly int SoftMask_ChannelWeights; //Field offset: 0xC
			[Token(Token = "0x400005F")]
			public static readonly int SoftMask_WorldToMask; //Field offset: 0x10
			[Token(Token = "0x4000060")]
			public static readonly int SoftMask_BorderRect; //Field offset: 0x14
			[Token(Token = "0x4000061")]
			public static readonly int SoftMask_UVBorderRect; //Field offset: 0x18
			[Token(Token = "0x4000062")]
			public static readonly int SoftMask_TileRepeat; //Field offset: 0x1C
			[Token(Token = "0x4000063")]
			public static readonly int SoftMask_InvertMask; //Field offset: 0x20
			[Token(Token = "0x4000064")]
			public static readonly int SoftMask_InvertOutsides; //Field offset: 0x24

			[Address(RVA = "0x1562030", Offset = "0x1561230", Length = "0x1D6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
			[Token(Token = "0x6000096")]
			private static Ids() { }

		}

		[Token(Token = "0x2000017")]
		internal enum SampleMaskResult
		{
			Success = 0,
			NonReadable = 1,
			NonTexture2D = 2,
		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004C")]
		public Vector4 maskRect; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400004D")]
		public Vector4 maskBorder; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400004E")]
		public Vector4 maskRectUV; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400004F")]
		public Vector4 maskBorderUV; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000050")]
		public Vector2 tileRepeat; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000051")]
		public Color maskChannelWeights; //Field offset: 0x48
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000052")]
		public Matrix4x4 worldToMask; //Field offset: 0x58
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000053")]
		public Texture texture; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4000054")]
		public BorderMode borderMode; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA4")]
		[Token(Token = "0x4000055")]
		public bool invertMask; //Field offset: 0xA4
		[FieldOffset(Offset = "0xA5")]
		[Token(Token = "0x4000056")]
		public bool invertOutsides; //Field offset: 0xA5

		[Token(Token = "0x1700001D")]
		public Texture activeTexture
		{
			[Address(RVA = "0x1562EA0", Offset = "0x15620A0", Length = "0x76")]
			[CalledBy(Type = typeof(MaterialParameters), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(Texture2D), Member = "get_whiteTexture", ReturnType = typeof(Texture2D))]
			[Token(Token = "0x600008C")]
			 get { } //Length: 118
		}

		[Address(RVA = "0x15624E0", Offset = "0x15616E0", Length = "0x346")]
		[CalledBy(Type = typeof(SoftMask), Member = "<.ctor>b__22_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(MaterialParameters), Member = "get_activeTexture", ReturnType = typeof(Texture))]
		[Calls(Type = typeof(Material), Member = "SetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Texture)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Material), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Material), Member = "SetMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Matrix4x4)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Material), Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600008E")]
		public void Apply(Material mat) { }

		[Address(RVA = "0x1562830", Offset = "0x1561A30", Length = "0x25")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802898A0")]
		[Token(Token = "0x6000094")]
		private float Frac(float v) { }

		[Address(RVA = "0x1562EA0", Offset = "0x15620A0", Length = "0x76")]
		[CalledBy(Type = typeof(MaterialParameters), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Texture2D), Member = "get_whiteTexture", ReturnType = typeof(Texture2D))]
		[Token(Token = "0x600008C")]
		public Texture get_activeTexture() { }

		[Address(RVA = "0x1562860", Offset = "0x1561A60", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802898A0")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000092")]
		private float Inset(float v, float x1, float x2, float u1, float u2, float repeat = 1) { }

		[Address(RVA = "0x15628E0", Offset = "0x1561AE0", Length = "0x17B")]
		[CalledBy(Type = typeof(MaterialParameters), Member = "MapBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(bool)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802898A0")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000093")]
		private float Inset(float v, float x1, float x2, float x3, float x4, float u1, float u2, float u3, float u4, float repeat = 1) { }

		[Address(RVA = "0x1562A60", Offset = "0x1561C60", Length = "0x141")]
		[CalledBy(Type = typeof(MaterialParameters), Member = "XY2UV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(MaterialParameters), Member = "Inset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
		[Token(Token = "0x6000091")]
		private Vector2 MapBorder(Vector2 localPos, bool repeat) { }

		[Address(RVA = "0x1562BB0", Offset = "0x1561DB0", Length = "0x75")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000090")]
		private Vector2 MapSimple(Vector2 localPos) { }

		[Address(RVA = "0x1562C30", Offset = "0x1561E30", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000095")]
		private float MaskValue(Color mask) { }

		[Address(RVA = "0x1562C80", Offset = "0x1561E80", Length = "0x154")]
		[CalledBy(Type = typeof(SoftMask), Member = "IsRaycastLocationValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(MaterialParameters), Member = "XY2UV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(Texture2D), Member = "GetPixelBilinear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(Color))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600008D")]
		public SampleMaskResult SampleMask(Vector2 localPos, out float mask) { }

		[Address(RVA = "0x1562DE0", Offset = "0x1561FE0", Length = "0xC0")]
		[CalledBy(Type = typeof(MaterialParameters), Member = "SampleMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Single&)}, ReturnType = "SoftMasking.SoftMask+MaterialParameters+SampleMaskResult")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(MaterialParameters), Member = "MapBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(bool)}, ReturnType = typeof(Vector2))]
		[Token(Token = "0x600008F")]
		private Vector2 XY2UV(Vector2 localPos) { }

	}

	[Token(Token = "0x2000014")]
	private class MaterialReplacerImpl : IMaterialReplacer
	{

		[Token(Token = "0x1700001B")]
		private static string DefaultUIETC1ShaderReplacement
		{
			[Address(RVA = "0x1563D80", Offset = "0x1562F80", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600007E")]
			private get { } //Length: 44
		}

		[Token(Token = "0x1700001C")]
		private static string DefaultUIShaderReplacement
		{
			[Address(RVA = "0x1563DB0", Offset = "0x1562FB0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600007F")]
			private get { } //Length: 44
		}

		[Token(Token = "0x1700001A")]
		public override int order
		{
			[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
			[CallerCount(Count = 51)]
			[DeduplicatedMethod]
			[Token(Token = "0x600007C")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000081")]
		public MaterialReplacerImpl() { }

		[Address(RVA = "0x1563D80", Offset = "0x1562F80", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600007E")]
		private static string get_DefaultUIETC1ShaderReplacement() { }

		[Address(RVA = "0x1563DB0", Offset = "0x1562FB0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600007F")]
		private static string get_DefaultUIShaderReplacement() { }

		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x600007C")]
		public override int get_order() { }

		[Address(RVA = "0x1563A40", Offset = "0x1562C40", Length = "0x23F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Material), Member = "get_shader", ReturnType = typeof(Shader))]
		[Calls(Type = typeof(Canvas), Member = "GetDefaultCanvasMaterial", ReturnType = typeof(Material))]
		[Calls(Type = typeof(Canvas), Member = "GetETC1SupportedCanvasMaterial", ReturnType = typeof(Material))]
		[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsInvalidInstructions]
		[Token(Token = "0x600007D")]
		public override Material Replace(Material original) { }

		[Address(RVA = "0x1563C80", Offset = "0x1562E80", Length = "0xF2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Material), Member = "CopyPropertiesFromMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000080")]
		private static Material Replace(Material original, Shader defaultReplacementShader) { }

	}

	[Token(Token = "0x2000015")]
	private static class Mathr
	{

		[Address(RVA = "0x1564710", Offset = "0x1563910", Length = "0x41")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000087")]
		public static Vector4 ApplyBorder(Vector4 v, Vector4 b) { }

		[Address(RVA = "0x15647A0", Offset = "0x15639A0", Length = "0x47")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000083")]
		public static Vector4 Div(Vector4 v, Vector2 s) { }

		[Address(RVA = "0x1564760", Offset = "0x1563960", Length = "0x31")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000084")]
		public static Vector2 Div(Vector2 v, Vector2 s) { }

		[Address(RVA = "0x15647F0", Offset = "0x15639F0", Length = "0x35")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600008B")]
		public static bool Inside(Vector2 v, Vector4 r) { }

		[Address(RVA = "0xCE3950", Offset = "0xCE2B50", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000089")]
		public static Vector2 Max(Vector4 r) { }

		[Address(RVA = "0x56A3D0", Offset = "0x5695D0", Length = "0x12")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000088")]
		public static Vector2 Min(Vector4 r) { }

		[Address(RVA = "0x1564830", Offset = "0x1563A30", Length = "0x41")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000085")]
		public static Vector4 Mul(Vector4 v, Vector2 s) { }

		[Address(RVA = "0x1564880", Offset = "0x1563A80", Length = "0xB0")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600008A")]
		public static Vector2 Remap(Vector2 c, Vector4 from, Vector4 to) { }

		[Address(RVA = "0x1564930", Offset = "0x1563B30", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000086")]
		public static Vector2 Size(Vector4 r) { }

		[Address(RVA = "0x1564950", Offset = "0x1563B50", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000082")]
		public static Vector4 ToVector(Rect r) { }

	}

	[Token(Token = "0x2000013")]
	private struct SourceParameters
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000046")]
		public Image image; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000047")]
		public Sprite sprite; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000048")]
		public BorderMode spriteBorderMode; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000049")]
		public float spritePixelsPerUnit; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400004A")]
		public Texture texture; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400004B")]
		public Rect textureUVRect; //Field offset: 0x20

	}

	[Token(Token = "0x200001C")]
	private struct WarningReporter
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000068")]
		private readonly object _owner; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000069")]
		private Texture _lastReadTexture; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400006A")]
		private Sprite _lastUsedSprite; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400006B")]
		private Sprite _lastUsedImageSprite; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400006C")]
		private Type _lastUsedImageType; //Field offset: 0x20

		[Address(RVA = "0x156A760", Offset = "0x1569960", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60000A8")]
		public WarningReporter(object owner) { }

		[Address(RVA = "0x156A1E0", Offset = "0x15693E0", Length = "0x240")]
		[CalledBy(Type = typeof(SoftMask), Member = "UpdateMaskParameters", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMask), Member = "CalculateMaskParameters", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Token(Token = "0x60000AB")]
		public void ImageUsed(Image image) { }

		[Address(RVA = "0x156A430", Offset = "0x1569630", Length = "0x10D")]
		[CalledBy(Type = typeof(SoftMask), Member = "UpdateMaskParameters", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMask), Member = "CalculateMaskParameters", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
		[Token(Token = "0x60000AA")]
		public void SpriteUsed(Sprite sprite, Errors errors) { }

		[Address(RVA = "0x156A540", Offset = "0x1569740", Length = "0x211")]
		[CalledBy(Type = typeof(SoftMask), Member = "IsRaycastLocationValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60000A9")]
		public void TextureRead(Texture texture, SampleMaskResult sampleResult) { }

	}

	[Token(Token = "0x4000032")]
	private const float DefaultPixelsPerUnit = 100; //Field offset: 0x0
	[Token(Token = "0x4000031")]
	private static readonly Rect DefaultUVRect; //Field offset: 0x0
	[Token(Token = "0x4000033")]
	private static readonly List<SoftMask> s_masks; //Field offset: 0x10
	[Token(Token = "0x4000034")]
	private static readonly List<SoftMaskable> s_maskables; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400001B")]
	private MaskSource _source; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400001C")]
	private RectTransform _separateMask; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400001D")]
	private Sprite _sprite; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400001E")]
	private BorderMode _spriteBorderMode; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x400001F")]
	private float _spritePixelsPerUnitMultiplier; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000020")]
	private Texture _texture; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000021")]
	private Rect _textureUVRect; //Field offset: 0x48
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000022")]
	private Color _channelWeights; //Field offset: 0x58
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x4000023")]
	private float _raycastThreshold; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	[Token(Token = "0x4000024")]
	private bool _invertMask; //Field offset: 0x6C
	[FieldOffset(Offset = "0x6D")]
	[SerializeField]
	[Token(Token = "0x4000025")]
	private bool _invertOutsides; //Field offset: 0x6D
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000026")]
	private readonly MaterialReplacements _materials; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000027")]
	private MaterialParameters _parameters; //Field offset: 0x78
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000028")]
	private WarningReporter _warningReporter; //Field offset: 0x120
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000029")]
	private Rect _lastMaskRect; //Field offset: 0x148
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x400002A")]
	private bool _maskingWasEnabled; //Field offset: 0x158
	[FieldOffset(Offset = "0x159")]
	[Token(Token = "0x400002B")]
	private bool _destroyed; //Field offset: 0x159
	[FieldOffset(Offset = "0x15A")]
	[Token(Token = "0x400002C")]
	private bool _dirty; //Field offset: 0x15A
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x400002D")]
	private readonly Queue<Transform> _transformsToSpawnMaskablesIn; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x400002E")]
	private RectTransform _maskTransform; //Field offset: 0x168
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x400002F")]
	private Graphic _graphic; //Field offset: 0x170
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x4000030")]
	private Canvas _canvas; //Field offset: 0x178

	[Token(Token = "0x17000017")]
	private Canvas canvas
	{
		[Address(RVA = "0x1568060", Offset = "0x1567260", Length = "0x128")]
		[CalledBy(Type = typeof(SoftMask), Member = "WorldToMask", ReturnType = typeof(Matrix4x4))]
		[CalledBy(Type = typeof(Diagnostics), Member = "AreCompeting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoftMask), typeof(SoftMask)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SoftMask), Member = "get_isMaskingEnabled", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SoftMask), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMask), Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMask), Member = "OnWillRenderCanvases", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMask), Member = "FillCommonParameters", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMask), Member = "SpriteToCanvasScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "T[]")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Token(Token = "0x600005A")]
		private get { } //Length: 296
	}

	[Token(Token = "0x17000010")]
	public Color channelWeights
	{
		[Address(RVA = "0x3B43B0", Offset = "0x3B35B0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003D")]
		 get { } //Length: 11
		[Address(RVA = "0x15683F0", Offset = "0x15675F0", Length = "0xC5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SoftMask), Member = "Set", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600003E")]
		 set { } //Length: 197
	}

	[Token(Token = "0x17000012")]
	public bool invertMask
	{
		[Address(RVA = "0x1568190", Offset = "0x1567390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000041")]
		 get { } //Length: 5
		[Address(RVA = "0x15684C0", Offset = "0x15676C0", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SoftMask), Member = "Set", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
		[Token(Token = "0x6000042")]
		 set { } //Length: 84
	}

	[Token(Token = "0x17000013")]
	public bool invertOutsides
	{
		[Address(RVA = "0x15681A0", Offset = "0x15673A0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000043")]
		 get { } //Length: 5
		[Address(RVA = "0x1568520", Offset = "0x1567720", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SoftMask), Member = "Set", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
		[Token(Token = "0x6000044")]
		 set { } //Length: 84
	}

	[Token(Token = "0x17000018")]
	private bool isBasedOnGraphic
	{
		[Address(RVA = "0x15681B0", Offset = "0x15673B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600005B")]
		private get { } //Length: 8
	}

	[Token(Token = "0x17000015")]
	public override bool isMaskingEnabled
	{
		[Address(RVA = "0x15681C0", Offset = "0x15673C0", Length = "0x6A")]
		[CalledBy(Type = typeof(Diagnostics), Member = "AreCompeting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoftMask), typeof(SoftMask)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(SoftMask), Member = "get_canvas", ReturnType = typeof(Canvas))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000046")]
		 get { } //Length: 106
	}

	[Token(Token = "0x17000014")]
	public bool isUsingRaycastFiltering
	{
		[Address(RVA = "0x1568230", Offset = "0x1567430", Length = "0xF")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000045")]
		 get { } //Length: 15
	}

	[Token(Token = "0x17000016")]
	private RectTransform maskTransform
	{
		[Address(RVA = "0x1568240", Offset = "0x1567440", Length = "0xD4")]
		[CalledBy(Type = typeof(SoftMask), Member = "FillCommonParameters", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMask), Member = "IsRaycastLocationValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SoftMask), Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMask), Member = "FindGraphic", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMask), Member = "UpdateMaskParameters", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMask), Member = "CalculateSpriteBased", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(BorderMode), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMask), Member = "CalculateTextureBased", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Rect)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMask), Member = "WorldToMask", ReturnType = typeof(Matrix4x4))]
		[CalledBy(Type = typeof(SoftMask), Member = "LocalMaskRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4)}, ReturnType = typeof(Vector4))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000059")]
		private get { } //Length: 212
	}

	[Token(Token = "0x17000011")]
	public float raycastThreshold
	{
		[Address(RVA = "0x96AC20", Offset = "0x969E20", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003F")]
		 get { } //Length: 6
		[Address(RVA = "0x96AED0", Offset = "0x96A0D0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000040")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700000E")]
	public RenderTexture renderTexture
	{
		[Address(RVA = "0x1568320", Offset = "0x1567520", Length = "0x72")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000039")]
		 get { } //Length: 114
		[Address(RVA = "0x1568580", Offset = "0x1567780", Length = "0x8E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(SoftMask), Member = "Set", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object)}, ReturnType = typeof(void))]
		[Token(Token = "0x600003A")]
		 set { } //Length: 142
	}

	[Token(Token = "0x17000009")]
	public RectTransform separateMask
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002F")]
		 get { } //Length: 5
		[Address(RVA = "0x1568610", Offset = "0x1567810", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(SoftMask), Member = "Set", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000030")]
		 set { } //Length: 186
	}

	[Token(Token = "0x17000019")]
	private override bool SoftMasking.ISoftMask.isAlive
	{
		[Address(RVA = "0x1567230", Offset = "0x1566430", Length = "0x5E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600005C")]
		private get { } //Length: 94
	}

	[Token(Token = "0x17000008")]
	public MaskSource source
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002D")]
		 get { } //Length: 4
		[Address(RVA = "0x15686D0", Offset = "0x15678D0", Length = "0x51")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SoftMask), Member = "Set", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(void))]
		[Token(Token = "0x600002E")]
		 set { } //Length: 81
	}

	[Token(Token = "0x1700000A")]
	public Sprite sprite
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000031")]
		 get { } //Length: 95
		[Address(RVA = "0x1568820", Offset = "0x1567A20", Length = "0x8E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(SoftMask), Member = "Set", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000032")]
		 set { } //Length: 142
	}

	[Token(Token = "0x1700000B")]
	public BorderMode spriteBorderMode
	{
		[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000033")]
		 get { } //Length: 4
		[Address(RVA = "0x1568730", Offset = "0x1567930", Length = "0x51")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SoftMask), Member = "Set", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(void))]
		[Token(Token = "0x6000034")]
		 set { } //Length: 81
	}

	[Token(Token = "0x1700000C")]
	public float spritePixelsPerUnitMultiplier
	{
		[Address(RVA = "0x3B4320", Offset = "0x3B3520", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000035")]
		 get { } //Length: 6
		[Address(RVA = "0x1568790", Offset = "0x1567990", Length = "0x83")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SoftMask), Member = "Set", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000036")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700000D")]
	public Texture2D texture
	{
		[Address(RVA = "0x15683A0", Offset = "0x15675A0", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000037")]
		 get { } //Length: 68
		[Address(RVA = "0x1568950", Offset = "0x1567B50", Length = "0x8E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(SoftMask), Member = "Set", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000038")]
		 set { } //Length: 142
	}

	[Token(Token = "0x1700000F")]
	public Rect textureUVRect
	{
		[Address(RVA = "0x3E3700", Offset = "0x3E2900", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003B")]
		 get { } //Length: 11
		[Address(RVA = "0x15688B0", Offset = "0x1567AB0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SoftMask), Member = "Set", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600003C")]
		 set { } //Length: 158
	}

	[Address(RVA = "0x1567BE0", Offset = "0x1566DE0", Length = "0x104")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600007A")]
	private static SoftMask() { }

	[Address(RVA = "0x1567CF0", Offset = "0x1566EF0", Length = "0x36A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MaterialReplacer), Member = "CollectGlobalReplacers", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<SoftMasking.IMaterialReplacer>))]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(MaterialReplacerChain), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<SoftMasking.IMaterialReplacer>), typeof(IMaterialReplacer)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x600002C")]
	public SoftMask() { }

	[Address(RVA = "0x1567740", Offset = "0x1566940", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MaterialParameters), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	[Token(Token = "0x600007B")]
	private void <.ctor>b__22_0(Material m) { }

	[Address(RVA = "0x1564980", Offset = "0x1563B80", Length = "0x21A")]
	[CalledBy(Type = typeof(SoftMask), Member = "CalculateSpriteBased", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(BorderMode), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector4), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Vector4), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600006E")]
	private static Vector4 AdjustBorders(Vector4 border, Vector4 rect) { }

	[Address(RVA = "0x1564BA0", Offset = "0x1563DA0", Length = "0x157")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SoftMask), Member = "DeduceSourceParameters", ReturnType = typeof(SourceParameters))]
	[Calls(Type = typeof(WarningReporter), Member = "ImageUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Diagnostics), Member = "CheckSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Errors))]
	[Calls(Type = typeof(WarningReporter), Member = "SpriteUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(Errors)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SoftMask), Member = "CalculateTextureBased", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SoftMask), Member = "CalculateSolidFill", ReturnType = typeof(void))]
	[Calls(Type = typeof(SoftMask), Member = "CalculateSpriteBased", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(BorderMode), typeof(float)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600006C")]
	private void CalculateMaskParameters() { }

	[Address(RVA = "0x1564D00", Offset = "0x1563F00", Length = "0x6B")]
	[CalledBy(Type = typeof(SoftMask), Member = "UpdateMaskParameters", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "CalculateMaskParameters", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SoftMask), Member = "CalculateTextureBased", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Rect)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000072")]
	private void CalculateSolidFill() { }

	[Address(RVA = "0x1564D70", Offset = "0x1563F70", Length = "0x683")]
	[CalledBy(Type = typeof(SoftMask), Member = "UpdateMaskParameters", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "CalculateMaskParameters", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DataUtility), Member = "GetPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(SoftMask), Member = "AdjustBorders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4), typeof(Vector4)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Sprite), Member = "get_border", ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(SoftMask), Member = "SpriteToCanvasScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DataUtility), Member = "GetOuterUV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(DataUtility), Member = "GetInnerUV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(SoftMask), Member = "FillCommonParameters", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SoftMask), Member = "get_maskTransform", ReturnType = typeof(RectTransform))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600006D")]
	private void CalculateSpriteBased(Sprite sprite, BorderMode borderMode, float spritePixelsPerUnit) { }

	[Address(RVA = "0x1565400", Offset = "0x1564600", Length = "0x153")]
	[CalledBy(Type = typeof(SoftMask), Member = "UpdateMaskParameters", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "CalculateMaskParameters", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "CalculateSolidFill", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SoftMask), Member = "FillCommonParameters", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SoftMask), Member = "get_maskTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000071")]
	private void CalculateTextureBased(Texture texture, Rect uvRect) { }

	[Address(RVA = "0x1565560", Offset = "0x1564760", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600004F")]
	private static float ClampPixelsPerUnitMultiplier(float value) { }

	[Address(RVA = "0x1565570", Offset = "0x1564770", Length = "0x304")]
	[CalledBy(Type = typeof(SoftMask), Member = "CalculateMaskParameters", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Diagnostics), Member = "PollErrors", ReturnType = typeof(Errors))]
	[CalledBy(Type = typeof(Diagnostics), Member = "get_image", ReturnType = typeof(Image))]
	[CalledBy(Type = typeof(Diagnostics), Member = "get_sprite", ReturnType = typeof(Sprite))]
	[CalledBy(Type = typeof(Diagnostics), Member = "get_texture", ReturnType = typeof(Texture))]
	[CalledBy(Type = typeof(Diagnostics), Member = "CheckImage", ReturnType = typeof(Errors))]
	[CalledBy(Type = typeof(Diagnostics), Member = "CheckTexture", ReturnType = typeof(Errors))]
	[CalledBy(Type = typeof(SoftMask), Member = "UpdateMaskParameters", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Sprite), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000069")]
	private SourceParameters DeduceSourceParameters() { }

	[Address(RVA = "0x1565880", Offset = "0x1564A80", Length = "0xFE")]
	[CalledBy(Type = typeof(SoftMask), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "SetShader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader&), typeof(Shader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000068")]
	private void DestroyMaterials() { }

	[Address(RVA = "0x1565980", Offset = "0x1564B80", Length = "0x16A")]
	[CalledBy(Type = typeof(SoftMask), Member = "CalculateSpriteBased", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(BorderMode), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "CalculateTextureBased", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SoftMask), Member = "get_maskTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Transform), Member = "get_worldToLocalMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(SoftMask), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Canvas), Member = "get_rootCanvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000073")]
	private void FillCommonParameters() { }

	[Address(RVA = "0x1565AF0", Offset = "0x1564CF0", Length = "0x17D")]
	[CalledBy(Type = typeof(SoftMask), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SoftMask), Member = "get_maskTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Graphic), Member = "RegisterDirtyVerticesCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "RegisterDirtyMaterialCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000061")]
	private void FindGraphic() { }

	[Address(RVA = "0x1565C70", Offset = "0x1564E70", Length = "0x279")]
	[CalledBy(Type = typeof(SoftMask), Member = "InvalidateChildren", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "NotifyChildrenThatMaskMightChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "SetShader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader&), typeof(Shader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Component), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClearListAtExit`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000067")]
	private void ForEachChildMaskable(Action<SoftMaskable> action, bool includeInactive = false) { }

	[Address(RVA = "0x1568060", Offset = "0x1567260", Length = "0x128")]
	[CalledBy(Type = typeof(SoftMask), Member = "WorldToMask", ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = typeof(Diagnostics), Member = "AreCompeting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoftMask), typeof(SoftMask)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SoftMask), Member = "get_isMaskingEnabled", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SoftMask), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "OnWillRenderCanvases", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "FillCommonParameters", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "SpriteToCanvasScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600005A")]
	private Canvas get_canvas() { }

	[Address(RVA = "0x3B43B0", Offset = "0x3B35B0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003D")]
	public Color get_channelWeights() { }

	[Address(RVA = "0x1568190", Offset = "0x1567390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000041")]
	public bool get_invertMask() { }

	[Address(RVA = "0x15681A0", Offset = "0x15673A0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000043")]
	public bool get_invertOutsides() { }

	[Address(RVA = "0x15681B0", Offset = "0x15673B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600005B")]
	private bool get_isBasedOnGraphic() { }

	[Address(RVA = "0x15681C0", Offset = "0x15673C0", Length = "0x6A")]
	[CalledBy(Type = typeof(Diagnostics), Member = "AreCompeting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoftMask), typeof(SoftMask)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SoftMask), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000046")]
	public override bool get_isMaskingEnabled() { }

	[Address(RVA = "0x1568230", Offset = "0x1567430", Length = "0xF")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000045")]
	public bool get_isUsingRaycastFiltering() { }

	[Address(RVA = "0x1568240", Offset = "0x1567440", Length = "0xD4")]
	[CalledBy(Type = typeof(SoftMask), Member = "LocalMaskRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4)}, ReturnType = typeof(Vector4))]
	[CalledBy(Type = typeof(SoftMask), Member = "CalculateTextureBased", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Rect)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "CalculateSpriteBased", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(BorderMode), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "UpdateMaskParameters", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "WorldToMask", ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = typeof(SoftMask), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "IsRaycastLocationValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SoftMask), Member = "FillCommonParameters", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "FindGraphic", ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Token(Token = "0x6000059")]
	private RectTransform get_maskTransform() { }

	[Address(RVA = "0x96AC20", Offset = "0x969E20", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003F")]
	public float get_raycastThreshold() { }

	[Address(RVA = "0x1568320", Offset = "0x1567520", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000039")]
	public RenderTexture get_renderTexture() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002F")]
	public RectTransform get_separateMask() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002D")]
	public MaskSource get_source() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000031")]
	public Sprite get_sprite() { }

	[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000033")]
	public BorderMode get_spriteBorderMode() { }

	[Address(RVA = "0x3B4320", Offset = "0x3B3520", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000035")]
	public float get_spritePixelsPerUnitMultiplier() { }

	[Address(RVA = "0x15683A0", Offset = "0x15675A0", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000037")]
	public Texture2D get_texture() { }

	[Address(RVA = "0x3E3700", Offset = "0x3E2900", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003B")]
	public Rect get_textureUVRect() { }

	[Address(RVA = "0x1565EF0", Offset = "0x15650F0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600006A")]
	public static BorderMode ImageTypeToBorderMode(Type type) { }

	[Address(RVA = "0x1565F10", Offset = "0x1565110", Length = "0x10A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SoftMask), Member = "ForEachChildMaskable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<SoftMasking.SoftMaskable>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000065")]
	private void InvalidateChildren() { }

	[Address(RVA = "0x1566020", Offset = "0x1565220", Length = "0xF")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600006B")]
	public static bool IsImageTypeSupported(Type type) { }

	[Address(RVA = "0x1566030", Offset = "0x1565230", Length = "0x260")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SoftMask), Member = "get_maskTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MaterialParameters), Member = "SampleMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Single&)}, ReturnType = typeof(SampleMaskResult))]
	[Calls(Type = typeof(WarningReporter), Member = "TextureRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(SampleMaskResult)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000048")]
	public override bool IsRaycastLocationValid(Vector2 sp, Camera cam) { }

	[Address(RVA = "0x15662A0", Offset = "0x15654A0", Length = "0x1F8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SoftMask), Member = "get_maskTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(SoftMask), Member = "FindGraphic", ReturnType = typeof(void))]
	[Calls(Type = typeof(SoftMask), Member = "SpawnMaskablesInChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Dequeue", ReturnType = typeof(object))]
	[Calls(Type = typeof(SoftMask), Member = "MarkTransformForMaskablesSpawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SoftMask), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600004C")]
	protected override void LateUpdate() { }

	[Address(RVA = "0x15664A0", Offset = "0x15656A0", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SoftMask), Member = "get_maskTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000076")]
	private Vector4 LocalMaskRect(Vector4 border) { }

	[Address(RVA = "0x1566560", Offset = "0x1565760", Length = "0x82")]
	[CalledBy(Type = typeof(SoftMask), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "OnTransformChildrenChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "SoftMasking.ISoftMask.UpdateTransformChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000053")]
	private void MarkTransformForMaskablesSpawn(Transform transform) { }

	[Address(RVA = "0x15665F0", Offset = "0x15657F0", Length = "0x11E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Sprite), Member = "get_border", ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(SoftMask), Member = "SpriteToCanvasScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000077")]
	private Vector2 MaskRepeat(Sprite sprite, float spritePixelsPerUnit, Vector4 centralPart) { }

	[Address(RVA = "0x1566710", Offset = "0x1565910", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "T[]")]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000062")]
	private Canvas NearestEnabledCanvas() { }

	[Address(RVA = "0x15667D0", Offset = "0x15659D0", Length = "0x10A")]
	[CalledBy(Type = typeof(SoftMask), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SoftMask), Member = "ForEachChildMaskable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<SoftMasking.SoftMaskable>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000066")]
	private void NotifyChildrenThatMaskMightChanged() { }

	[Address(RVA = "0x15668E0", Offset = "0x1565AE0", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SoftMask), Member = "NotifyChildrenThatMaskMightChanged", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000051")]
	protected virtual void OnCanvasHierarchyChanged() { }

	[Address(RVA = "0x1566920", Offset = "0x1565B20", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SoftMask), Member = "NotifyChildrenThatMaskMightChanged", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600004B")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x1566950", Offset = "0x1565B50", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600004E")]
	protected virtual void OnDidApplyAnimationProperties() { }

	[Address(RVA = "0x1566970", Offset = "0x1565B70", Length = "0x195")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Canvas), Member = "remove_willRenderCanvases", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WillRenderCanvases)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "UnregisterDirtyVerticesCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "UnregisterDirtyMaterialCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SoftMask), Member = "NotifyChildrenThatMaskMightChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(SoftMask), Member = "DestroyMaterials", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600004A")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x1566B10", Offset = "0x1565D10", Length = "0x16B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "get_instance", ReturnType = typeof(CanvasUpdateRegistry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Canvas), Member = "add_willRenderCanvases", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WillRenderCanvases)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SoftMask), Member = "NotifyChildrenThatMaskMightChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(SoftMask), Member = "MarkTransformForMaskablesSpawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SoftMask), Member = "FindGraphic", ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SoftMask), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SoftMask), Member = "UpdateMaskParameters", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000049")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x1566C80", Offset = "0x1565E80", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000060")]
	private void OnGraphicDirty() { }

	[Address(RVA = "0x1566950", Offset = "0x1565B50", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600004D")]
	protected virtual void OnRectTransformDimensionsChange() { }

	[Address(RVA = "0x1566C90", Offset = "0x1565E90", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(SoftMask), Member = "MarkTransformForMaskablesSpawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000052")]
	private void OnTransformChildrenChanged() { }

	[Address(RVA = "0x1566CC0", Offset = "0x1565EC0", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000050")]
	protected virtual void OnTransformParentChanged() { }

	[Address(RVA = "0x1566D00", Offset = "0x1565F00", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SoftMask), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SoftMask), Member = "UpdateMaskParameters", ReturnType = typeof(void))]
	[Token(Token = "0x6000057")]
	private void OnWillRenderCanvases() { }

	[Address(RVA = "0x1566D90", Offset = "0x1565F90", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Diagnostics), Member = "PollErrors", ReturnType = typeof(Errors))]
	[Token(Token = "0x6000047")]
	public Errors PollErrors() { }

	[Address(RVA = "0x1566DD0", Offset = "0x1565FD0", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000070")]
	private Vector4 PreserveSpriteAspectRatio(Vector4 rect, Vector2 spriteSize) { }

	[Address(RVA = "0x75C380", Offset = "0x75B580", Length = "0xB")]
	[CalledBy(Type = typeof(SoftMask), Member = "set_textureUVRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "set_channelWeights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "set_invertMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "set_invertOutsides", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000078")]
	private void Set(ref T field, T value) { }

	[Address(RVA = "0x15683F0", Offset = "0x15675F0", Length = "0xC5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SoftMask), Member = "Set", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600003E")]
	public void set_channelWeights(Color value) { }

	[Address(RVA = "0x15684C0", Offset = "0x15676C0", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SoftMask), Member = "Set", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
	[Token(Token = "0x6000042")]
	public void set_invertMask(bool value) { }

	[Address(RVA = "0x1568520", Offset = "0x1567720", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SoftMask), Member = "Set", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
	[Token(Token = "0x6000044")]
	public void set_invertOutsides(bool value) { }

	[Address(RVA = "0x96AED0", Offset = "0x96A0D0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000040")]
	public void set_raycastThreshold(float value) { }

	[Address(RVA = "0x1568580", Offset = "0x1567780", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SoftMask), Member = "Set", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x600003A")]
	public void set_renderTexture(RenderTexture value) { }

	[Address(RVA = "0x1568610", Offset = "0x1567810", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SoftMask), Member = "Set", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000030")]
	public void set_separateMask(RectTransform value) { }

	[Address(RVA = "0x15686D0", Offset = "0x15678D0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SoftMask), Member = "Set", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(void))]
	[Token(Token = "0x600002E")]
	public void set_source(MaskSource value) { }

	[Address(RVA = "0x1568820", Offset = "0x1567A20", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SoftMask), Member = "Set", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000032")]
	public void set_sprite(Sprite value) { }

	[Address(RVA = "0x1568730", Offset = "0x1567930", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SoftMask), Member = "Set", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(void))]
	[Token(Token = "0x6000034")]
	public void set_spriteBorderMode(BorderMode value) { }

	[Address(RVA = "0x1568790", Offset = "0x1567990", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SoftMask), Member = "Set", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(float)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000036")]
	public void set_spritePixelsPerUnitMultiplier(float value) { }

	[Address(RVA = "0x1568950", Offset = "0x1567B50", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SoftMask), Member = "Set", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000038")]
	public void set_texture(Texture2D value) { }

	[Address(RVA = "0x15688B0", Offset = "0x1567AB0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SoftMask), Member = "Set", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T"}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600003C")]
	public void set_textureUVRect(Rect value) { }

	[Address(RVA = "0x1566E80", Offset = "0x1566080", Length = "0x17D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SoftMask), Member = "DestroyMaterials", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SoftMask), Member = "ForEachChildMaskable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<SoftMasking.SoftMaskable>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000079")]
	private void SetShader(ref Shader field, Shader value) { }

	[Address(RVA = "0x1567000", Offset = "0x1566200", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600006F")]
	private bool ShouldPreserveAspect() { }

	[Address(RVA = "0x1567230", Offset = "0x1566430", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600005C")]
	private override bool SoftMasking.ISoftMask.get_isAlive() { }

	[Address(RVA = "0x15670B0", Offset = "0x15662B0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MaterialReplacements), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600005D")]
	private override Material SoftMasking.ISoftMask.GetReplacement(Material original) { }

	[Address(RVA = "0x15670D0", Offset = "0x15662D0", Length = "0x146")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600005E")]
	private override void SoftMasking.ISoftMask.ReleaseReplacement(Material replacement) { }

	[Address(RVA = "0x1567220", Offset = "0x1566420", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SoftMask), Member = "MarkTransformForMaskablesSpawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[Token(Token = "0x600005F")]
	private override void SoftMasking.ISoftMask.UpdateTransformChildren(Transform transform) { }

	[Address(RVA = "0x15674F0", Offset = "0x15666F0", Length = "0xC0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Dequeue", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SoftMask), Member = "SpawnMaskablesInChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000054")]
	private void SpawnMaskables() { }

	[Address(RVA = "0x1567290", Offset = "0x1566490", Length = "0x25E")]
	[CalledBy(Type = typeof(SoftMask), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "SpawnMaskables", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(ClearListAtExit`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000064")]
	private void SpawnMaskablesInChildren(Transform root) { }

	[Address(RVA = "0x15675C0", Offset = "0x15667C0", Length = "0x9D")]
	[CalledBy(Type = typeof(SoftMask), Member = "CalculateSpriteBased", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(BorderMode), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "MaskRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(float), typeof(Vector4)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SoftMask), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_referencePixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000074")]
	private float SpriteToCanvasScale(float spritePixelsPerUnit) { }

	[Address(RVA = "0x1567660", Offset = "0x1566860", Length = "0xD4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "get_instance", ReturnType = typeof(CanvasUpdateRegistry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Canvas), Member = "add_willRenderCanvases", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WillRenderCanvases)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000055")]
	private void SubscribeOnWillRenderCanvases() { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000058")]
	private static T Touch(T obj) { }

	[Address(RVA = "0x1567750", Offset = "0x1566950", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Canvas), Member = "remove_willRenderCanvases", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WillRenderCanvases)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000056")]
	private void UnsubscribeFromWillRenderCanvases() { }

	[Address(RVA = "0x15677C0", Offset = "0x15669C0", Length = "0x2BF")]
	[CalledBy(Type = typeof(SoftMask), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMask), Member = "OnWillRenderCanvases", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Diagnostics), Member = "CheckSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Errors))]
	[Calls(Type = typeof(SoftMask), Member = "CalculateSpriteBased", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(BorderMode), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SoftMask), Member = "CalculateTextureBased", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SoftMask), Member = "CalculateSolidFill", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WarningReporter), Member = "SpriteUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(Errors)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SoftMask), Member = "DeduceSourceParameters", ReturnType = typeof(SourceParameters))]
	[Calls(Type = typeof(WarningReporter), Member = "ImageUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_hasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Transform), Member = "get_hasChanged", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SoftMask), Member = "get_maskTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000063")]
	private void UpdateMaskParameters() { }

	[Address(RVA = "0x1567A80", Offset = "0x1566C80", Length = "0x153")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SoftMask), Member = "get_maskTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Transform), Member = "get_worldToLocalMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(SoftMask), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Canvas), Member = "get_rootCanvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000075")]
	private Matrix4x4 WorldToMask() { }

}

