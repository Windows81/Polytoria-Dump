namespace TMPro;

[AddComponentMenu("UI/TextMeshPro - Text (UI)", 11)]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/TextMeshPro/index.html")]
[RequireComponent(typeof(RectTransform))]
[RequireComponent(typeof(CanvasRenderer))]
[Token(Token = "0x2000018")]
public class TextMeshProUGUI : TMP_Text, ILayoutElement
{
	[CompilerGenerated]
	[Token(Token = "0x2000019")]
	private sealed class <DelayedGraphicRebuild>d__18 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400009C")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400009D")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400009E")]
		public TextMeshProUGUI <>4__this; //Field offset: 0x20

		[Token(Token = "0x1700002F")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x600010E")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000030")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000110")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600010B")]
		public <DelayedGraphicRebuild>d__18(int <>1__state) { }

		[Address(RVA = "0x189F690", Offset = "0x189E890", Length = "0xD6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600010D")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600010E")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000110")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x189F770", Offset = "0x189E970", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x600010F")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600010C")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200001A")]
	private sealed class <DelayedMaterialRebuild>d__19 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400009F")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000A0")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000A1")]
		public TextMeshProUGUI <>4__this; //Field offset: 0x20

		[Token(Token = "0x17000031")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000114")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000032")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000116")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000111")]
		public <DelayedMaterialRebuild>d__19(int <>1__state) { }

		[Address(RVA = "0x189F7B0", Offset = "0x189E9B0", Length = "0xE2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000113")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000114")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000116")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x189F8A0", Offset = "0x189EAA0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6000115")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000112")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x4000086")]
	private static ProfilerMarker k_GenerateTextMarker; //Field offset: 0x0
	[Token(Token = "0x4000087")]
	private static ProfilerMarker k_SetArraySizesMarker; //Field offset: 0x8
	[Token(Token = "0x4000088")]
	private static ProfilerMarker k_GenerateTextPhaseIMarker; //Field offset: 0x10
	[Token(Token = "0x4000089")]
	private static ProfilerMarker k_ParseMarkupTextMarker; //Field offset: 0x18
	[Token(Token = "0x400008A")]
	private static ProfilerMarker k_CharacterLookupMarker; //Field offset: 0x20
	[Token(Token = "0x400008B")]
	private static ProfilerMarker k_HandleGPOSFeaturesMarker; //Field offset: 0x28
	[Token(Token = "0x400008C")]
	private static ProfilerMarker k_CalculateVerticesPositionMarker; //Field offset: 0x30
	[Token(Token = "0x400008D")]
	private static ProfilerMarker k_ComputeTextMetricsMarker; //Field offset: 0x38
	[Token(Token = "0x400008E")]
	private static ProfilerMarker k_HandleVisibleCharacterMarker; //Field offset: 0x40
	[Token(Token = "0x400008F")]
	private static ProfilerMarker k_HandleWhiteSpacesMarker; //Field offset: 0x48
	[Token(Token = "0x4000090")]
	private static ProfilerMarker k_HandleHorizontalLineBreakingMarker; //Field offset: 0x50
	[Token(Token = "0x4000091")]
	private static ProfilerMarker k_HandleVerticalLineBreakingMarker; //Field offset: 0x58
	[Token(Token = "0x4000092")]
	private static ProfilerMarker k_SaveGlyphVertexDataMarker; //Field offset: 0x60
	[Token(Token = "0x4000093")]
	private static ProfilerMarker k_ComputeCharacterAdvanceMarker; //Field offset: 0x68
	[Token(Token = "0x4000094")]
	private static ProfilerMarker k_HandleCarriageReturnMarker; //Field offset: 0x70
	[Token(Token = "0x4000095")]
	private static ProfilerMarker k_HandleLineTerminationMarker; //Field offset: 0x78
	[Token(Token = "0x4000096")]
	private static ProfilerMarker k_SavePageInfoMarker; //Field offset: 0x80
	[Token(Token = "0x4000097")]
	private static ProfilerMarker k_SaveTextExtentMarker; //Field offset: 0x88
	[Token(Token = "0x4000098")]
	private static ProfilerMarker k_SaveProcessingStatesMarker; //Field offset: 0x90
	[Token(Token = "0x4000099")]
	private static ProfilerMarker k_GenerateTextPhaseIIMarker; //Field offset: 0x98
	[Token(Token = "0x400009A")]
	private static ProfilerMarker k_GenerateTextPhaseIIIMarker; //Field offset: 0xA0
	[FieldOffset(Offset = "0x6E8")]
	[Token(Token = "0x4000071")]
	private bool m_isRebuildingLayout; //Field offset: 0x6E8
	[FieldOffset(Offset = "0x6F0")]
	[Token(Token = "0x4000072")]
	private Coroutine m_DelayedGraphicRebuild; //Field offset: 0x6F0
	[FieldOffset(Offset = "0x6F8")]
	[Token(Token = "0x4000073")]
	private Coroutine m_DelayedMaterialRebuild; //Field offset: 0x6F8
	[FieldOffset(Offset = "0x700")]
	[Token(Token = "0x4000074")]
	private bool m_ShouldUpdateCulling; //Field offset: 0x700
	[FieldOffset(Offset = "0x704")]
	[Token(Token = "0x4000075")]
	private Rect m_ClipRect; //Field offset: 0x704
	[FieldOffset(Offset = "0x714")]
	[Token(Token = "0x4000076")]
	private bool m_ValidRect; //Field offset: 0x714
	[CompilerGenerated]
	[FieldOffset(Offset = "0x718")]
	[Token(Token = "0x4000077")]
	private Action<TMP_TextInfo> OnPreRenderText; //Field offset: 0x718
	[FieldOffset(Offset = "0x720")]
	[SerializeField]
	[Token(Token = "0x4000078")]
	private bool m_hasFontAssetChanged; //Field offset: 0x720
	[FieldOffset(Offset = "0x728")]
	[Token(Token = "0x4000079")]
	protected TMP_SubMeshUI[] m_subTextObjects; //Field offset: 0x728
	[FieldOffset(Offset = "0x730")]
	[Token(Token = "0x400007A")]
	private float m_previousLossyScaleY; //Field offset: 0x730
	[FieldOffset(Offset = "0x738")]
	[Token(Token = "0x400007B")]
	private Vector3[] m_RectTransformCorners; //Field offset: 0x738
	[FieldOffset(Offset = "0x740")]
	[Token(Token = "0x400007C")]
	private CanvasRenderer m_canvasRenderer; //Field offset: 0x740
	[FieldOffset(Offset = "0x748")]
	[Token(Token = "0x400007D")]
	private Canvas m_canvas; //Field offset: 0x748
	[FieldOffset(Offset = "0x750")]
	[Token(Token = "0x400007E")]
	private float m_CanvasScaleFactor; //Field offset: 0x750
	[FieldOffset(Offset = "0x754")]
	[Token(Token = "0x400007F")]
	private bool m_isFirstAllocation; //Field offset: 0x754
	[FieldOffset(Offset = "0x758")]
	[Token(Token = "0x4000080")]
	private int m_max_characters; //Field offset: 0x758
	[FieldOffset(Offset = "0x760")]
	[SerializeField]
	[Token(Token = "0x4000081")]
	private Material m_baseMaterial; //Field offset: 0x760
	[FieldOffset(Offset = "0x768")]
	[Token(Token = "0x4000082")]
	private bool m_isScrollRegionSet; //Field offset: 0x768
	[FieldOffset(Offset = "0x76C")]
	[SerializeField]
	[Token(Token = "0x4000083")]
	private Vector4 m_maskOffset; //Field offset: 0x76C
	[FieldOffset(Offset = "0x77C")]
	[Token(Token = "0x4000084")]
	private Matrix4x4 m_EnvMapMatrix; //Field offset: 0x77C
	[FieldOffset(Offset = "0x7BC")]
	[Token(Token = "0x4000085")]
	private bool m_isRegisteredForEvents; //Field offset: 0x7BC
	[FieldOffset(Offset = "0x7C0")]
	[Token(Token = "0x400009B")]
	private Dictionary<Int32, Int32> materialIndexPairs; //Field offset: 0x7C0

	[Token(Token = "0x14000002")]
	public virtual event Action<TMP_TextInfo> OnPreRenderText
	{
		[Address(RVA = "0x187F300", Offset = "0x187E500", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60000DD")]
		 add { } //Length: 186
		[Address(RVA = "0x187F4F0", Offset = "0x187E6F0", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60000DE")]
		 remove { } //Length: 186
	}

	[Token(Token = "0x1700002B")]
	public virtual bool autoSizeTextContainer
	{
		[Address(RVA = "0x187F3C0", Offset = "0x187E5C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C2")]
		 get { } //Length: 8
		[Address(RVA = "0x187F5B0", Offset = "0x187E7B0", Length = "0x81")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60000C3")]
		 set { } //Length: 129
	}

	[Token(Token = "0x1700002D")]
	public CanvasRenderer canvasRenderer
	{
		[Address(RVA = "0x187F3D0", Offset = "0x187E5D0", Length = "0x99")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60000C5")]
		 get { } //Length: 153
	}

	[Token(Token = "0x1700002E")]
	public Vector4 maskOffset
	{
		[Address(RVA = "0x187F470", Offset = "0x187E670", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60000D2")]
		 get { } //Length: 14
		[Address(RVA = "0x187F640", Offset = "0x187E840", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextMeshProUGUI), Member = "UpdateMask", ReturnType = typeof(void))]
		[Token(Token = "0x60000D3")]
		 set { } //Length: 39
	}

	[Token(Token = "0x1700002A")]
	public virtual Material materialForRendering
	{
		[Address(RVA = "0x187F480", Offset = "0x187E680", Length = "0x5D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_MaterialManager), Member = "GetMaterialForRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaskableGraphic), typeof(Material)}, ReturnType = typeof(Material))]
		[Token(Token = "0x60000C1")]
		 get { } //Length: 93
	}

	[Token(Token = "0x1700002C")]
	public virtual Mesh mesh
	{
		[Address(RVA = "0x187F4E0", Offset = "0x187E6E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C4")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x187ECE0", Offset = "0x187DEE0", Length = "0x4FE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Token(Token = "0x600010A")]
	private static TextMeshProUGUI() { }

	[Address(RVA = "0x187F1E0", Offset = "0x187E3E0", Length = "0x118")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Text), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000109")]
	public TextMeshProUGUI() { }

	[Address(RVA = "0x187F300", Offset = "0x187E500", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60000DD")]
	public virtual void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[Address(RVA = "0x1875A80", Offset = "0x1874C80", Length = "0x32A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_TextInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(TMP_Character), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000E3")]
	protected virtual void Awake() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C6")]
	public override void CalculateLayoutInputHorizontal() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C7")]
	public override void CalculateLayoutInputVertical() { }

	[Address(RVA = "0x1875DB0", Offset = "0x1874FB0", Length = "0x128")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60000DC")]
	public virtual void ClearMesh() { }

	[Address(RVA = "0x1875EE0", Offset = "0x18750E0", Length = "0x141")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000FB")]
	public virtual void ComputeMarginSize() { }

	[Address(RVA = "0x1876030", Offset = "0x1875230", Length = "0x224")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Rect), Member = "Overlaps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CanvasRenderer), Member = "get_cull", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CanvasRenderer), Member = "set_cull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`1), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000D5")]
	public virtual void Cull(Rect clipRect, bool validRect) { }

	[Address(RVA = "0x1876260", Offset = "0x1875460", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<DelayedGraphicRebuild>d__18))]
	[Token(Token = "0x60000CC")]
	private IEnumerator DelayedGraphicRebuild() { }

	[Address(RVA = "0x18762D0", Offset = "0x18754D0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<DelayedMaterialRebuild>d__19))]
	[Token(Token = "0x60000CD")]
	private IEnumerator DelayedMaterialRebuild() { }

	[Address(RVA = "0x1876340", Offset = "0x1875540", Length = "0x109")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000105")]
	protected virtual void DestroySubMeshObjects() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000EC")]
	private void DisableMasking() { }

	[Address(RVA = "0x1876450", Offset = "0x1875650", Length = "0x23C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Material), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Texture))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "DisableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextMeshProUGUI), Member = "UpdateMask", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000EB")]
	private void EnableMasking() { }

	[Address(RVA = "0x1876690", Offset = "0x1875890", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TextMeshProUGUI), Member = "OnPreRenderCanvas", ReturnType = typeof(void))]
	[Token(Token = "0x60000DA")]
	public virtual void ForceMeshUpdate(bool ignoreActiveState = false, bool forceTextReparsing = false) { }

	[Address(RVA = "0x1866BB0", Offset = "0x1865DB0", Length = "0x4174")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(char), Member = "IsLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B30")]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002140")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DE0")]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800024C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0E20")]
	[Calls(Type = typeof(GlyphPairAdjustmentRecord), Member = "get_firstAdjustmentRecord", ReturnType = typeof(GlyphAdjustmentRecord))]
	[Calls(Type = typeof(GlyphAdjustmentRecord), Member = "get_glyphValueRecord", ReturnType = typeof(GlyphValueRecord))]
	[Calls(Type = typeof(GlyphValueRecord), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphValueRecord), typeof(GlyphValueRecord)}, ReturnType = typeof(GlyphValueRecord))]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "IsBaseGlyph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0E30")]
	[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Vector3), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D8530")]
	[Calls(Type = typeof(Quaternion), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Quaternion)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Matrix4x4), Member = "Rotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Vector3), Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint3x4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0EA0")]
	[Calls(Type = typeof(TMP_Text), Member = "RestoreWordWrappingState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WordWrapState&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(char), Member = "IsSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0E50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0E40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B0E70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD50")]
	[Calls(Type = typeof(TMP_Text), Member = "set_firstVisibleCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "get_characterLookupTable", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, TMPro.TMP_Character>))]
	[Calls(Type = typeof(TMP_TextInfo), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MaterialReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_FontAsset), typeof(TMP_SpriteAsset), typeof(Material), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(TMP_SpriteAnimator), Member = "StopAllAnimations", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18185A9C0")]
	[Calls(Type = typeof(FaceInfo), Member = "get_ascentLine", ReturnType = typeof(float))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_TextInfo), Member = "ClearPageInfo", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_TextInfo), Member = "ClearLineInfo", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "SaveWordWrappingState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WordWrapState&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMPro.TMP_TextProcessingStack`1<TMPro.WordWrapState>), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(uint), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002330")]
	[CallsDeduplicatedMethods(Count = 89)]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000102")]
	protected override void GenerateTextMesh() { }

	[Address(RVA = "0x187F3C0", Offset = "0x187E5C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C2")]
	public virtual bool get_autoSizeTextContainer() { }

	[Address(RVA = "0x187F3D0", Offset = "0x187E5D0", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60000C5")]
	public CanvasRenderer get_canvasRenderer() { }

	[Address(RVA = "0x187F470", Offset = "0x187E670", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60000D2")]
	public Vector4 get_maskOffset() { }

	[Address(RVA = "0x187F480", Offset = "0x187E680", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_MaterialManager), Member = "GetMaterialForRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaskableGraphic), typeof(Material)}, ReturnType = typeof(Material))]
	[Token(Token = "0x60000C1")]
	public virtual Material get_materialForRendering() { }

	[Address(RVA = "0x187F4E0", Offset = "0x187E6E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C4")]
	public virtual Mesh get_mesh() { }

	[Address(RVA = "0x18769B0", Offset = "0x1875BB0", Length = "0x147")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_ListPool`1), Member = "Get", ReturnType = "System.Collections.Generic.List`1<T>")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_ListPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60000E8")]
	private Canvas GetCanvas() { }

	[Address(RVA = "0x1876740", Offset = "0x1875940", Length = "0x265")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_rootCanvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "InverseTransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000107")]
	internal virtual Rect GetCanvasSpaceClippingRect() { }

	[Address(RVA = "0x1876B00", Offset = "0x1875D00", Length = "0x2E9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mesh), Member = "get_bounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_SubMeshUI), Member = "get_mesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000106")]
	protected virtual Bounds GetCompoundBounds() { }

	[Address(RVA = "0x1876DF0", Offset = "0x1875FF0", Length = "0x16C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ShaderUtilities), Member = "GetShaderPropertyIDs", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60000EE")]
	protected virtual Material GetMaterial(Material mat) { }

	[Address(RVA = "0x1876F60", Offset = "0x1876160", Length = "0x24D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(TMP_Text), Member = "get_fontMaterial", ReturnType = typeof(Material))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000EF")]
	protected virtual Material[] GetMaterials(Material[] mats) { }

	[Address(RVA = "0x18771B0", Offset = "0x18763B0", Length = "0x153")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_Text), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(MaskUtilities), Member = "FindRootSortOverrideCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(MaskUtilities), Member = "GetStencilDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Transform)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StencilMaterial), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(int), typeof(StencilOp), typeof(CompareFunction), typeof(ColorWriteMask), typeof(int), typeof(int)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(StencilMaterial), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60000D0")]
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

	[Address(RVA = "0x1877310", Offset = "0x1876510", Length = "0x216")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000F1")]
	protected virtual Material[] GetSharedMaterials() { }

	[Address(RVA = "0x1877530", Offset = "0x1876730", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RectTransform), Member = "GetLocalCorners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000103")]
	protected virtual Vector3[] GetTextContainerLocalCorners() { }

	[Address(RVA = "0x18775E0", Offset = "0x18767E0", Length = "0xF8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60000DB")]
	public virtual TMP_TextInfo GetTextInfo(string text) { }

	[Address(RVA = "0x18776E0", Offset = "0x18768E0", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000D9")]
	protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	[Address(RVA = "0x18777C0", Offset = "0x18769C0", Length = "0x110")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000D8")]
	protected virtual void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	[Address(RVA = "0x18778E0", Offset = "0x1876AE0", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(TextMeshProUGUI), Member = "UpdateSDFScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextMeshProUGUI), Member = "OnPreRenderCanvas", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextMeshProUGUI), Member = "UpdateEnvMapMatrix", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000100")]
	internal virtual void InternalUpdate() { }

	[Address(RVA = "0x18779B0", Offset = "0x1876BB0", Length = "0x725")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_Text), Member = "GetSpecialCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultFontAsset", ReturnType = typeof(TMP_FontAsset))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "get_atlasTexture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Material), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Texture))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "get_characterLookupTable", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, TMPro.TMP_Character>))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ShaderUtilities), Member = "GetShaderPropertyIDs", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000E7")]
	protected virtual void LoadFontAsset() { }

	[Address(RVA = "0x18780E0", Offset = "0x18772E0", Length = "0x124")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MaskableGraphic), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_UpdateManager), Member = "RegisterTextObjectForUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_UpdateManager), Member = "UnRegisterTextObjectForUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000FD")]
	protected virtual void OnCanvasHierarchyChanged() { }

	[Address(RVA = "0x1878210", Offset = "0x1877410", Length = "0x167")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicRegistry), Member = "UnregisterGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_UpdateManager), Member = "UnRegisterTextObjectForUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_MaterialManager), Member = "ReleaseStencilMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60000E6")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x1878380", Offset = "0x1877580", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000FC")]
	protected virtual void OnDidApplyAnimationProperties() { }

	[Address(RVA = "0x18783C0", Offset = "0x18775C0", Length = "0x189")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GraphicRegistry), Member = "UnregisterGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "UnRegisterCanvasElementForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_UpdateManager), Member = "UnRegisterTextObjectForUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CanvasRenderer), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60000E5")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x1878550", Offset = "0x1877750", Length = "0x270")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_ListPool`1), Member = "Get", ReturnType = "System.Collections.Generic.List`1<T>")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_ListPool`1), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GraphicRegistry), Member = "RegisterGraphicForCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Graphic)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_UpdateManager), Member = "RegisterTextObjectForUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60000E4")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x18787D0", Offset = "0x18779D0", Length = "0x2B7")]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasUpdate)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "ForceMeshUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "InternalUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "UpdateSDFScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_Text), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "UpdateFontAssetsInUpdateQueue", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "ParseInputText", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000101")]
	private void OnPreRenderCanvas() { }

	[Address(RVA = "0x1878A90", Offset = "0x1877C90", Length = "0x3BE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_scaleFactor", ReturnType = typeof(float))]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(TMP_SubMeshUI), Member = "SetPivotDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60000FF")]
	protected virtual void OnRectTransformDimensionsChange() { }

	[Address(RVA = "0x1878E50", Offset = "0x1878050", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MaskableGraphic), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000FE")]
	protected virtual void OnTransformParentChanged() { }

	[Address(RVA = "0x1878EB0", Offset = "0x18780B0", Length = "0xDD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextMeshProUGUI), Member = "OnPreRenderCanvas", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000CE")]
	public virtual void Rebuild(CanvasUpdate update) { }

	[Address(RVA = "0x1878F90", Offset = "0x1878190", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MaskableGraphic), Member = "RecalculateClipping", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60000D4")]
	public virtual void RecalculateClipping() { }

	[Address(RVA = "0x187F4F0", Offset = "0x187E6F0", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60000DE")]
	public virtual void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[Address(RVA = "0x187F5B0", Offset = "0x187E7B0", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C3")]
	public virtual void set_autoSizeTextContainer(bool value) { }

	[Address(RVA = "0x187F640", Offset = "0x187E840", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextMeshProUGUI), Member = "UpdateMask", ReturnType = typeof(void))]
	[Token(Token = "0x60000D3")]
	public void set_maskOffset(Vector4 value) { }

	[Address(RVA = "0x1878FA0", Offset = "0x18781A0", Length = "0x137")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000104")]
	protected virtual void SetActiveSubMeshes(bool state) { }

	[Address(RVA = "0x18790E0", Offset = "0x18782E0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000CB")]
	public virtual void SetAllDirty() { }

	[Address(RVA = "0x1879130", Offset = "0x1878330", Length = "0x31FD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_FontAssetUtilities), Member = "GetCharacterFromFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(bool), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_Character))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_MaterialManager), Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset), typeof(Material), typeof(int)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(Glyph), Member = "get_atlasIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "GetGlyphVariantIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultFontAsset", ReturnType = typeof(TMP_FontAsset))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "TryAddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialReference), Member = "AddMaterialReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(TMP_SpriteAsset), typeof(MaterialReference[]&), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_SubMeshUI), Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextMeshProUGUI), typeof(MaterialReference)}, ReturnType = typeof(TMP_SubMeshUI))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "set_pivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_SubMeshUI), Member = "set_fallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_MeshInfo), Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_SubMeshUI), Member = "get_mesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(TMP_MeshInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TMP_FontAssetUtilities), Member = "GetCharacterFromFontAssets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(System.Collections.Generic.List`1<TMPro.TMP_FontAsset>), typeof(bool), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_Character))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_fallbackFontAssets", ReturnType = typeof(System.Collections.Generic.List`1<TMPro.TMP_FontAsset>))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_missingGlyphCharacter", ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_MaterialManager), Member = "GetFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Material)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_warningsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_TextInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_matchMaterialPreset", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(MaterialReference), Member = "AddMaterialReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(TMP_FontAsset), typeof(MaterialReference[]&), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "DoMissingGlyphCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_TextElement))]
	[Calls(Type = typeof(TMP_FontAssetUtilities), Member = "GetTextElementFromTextAssets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(System.Collections.Generic.List`1<TMPro.TMP_Asset>), typeof(bool), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_TextElement))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_emojiFallbackTextAssets", ReturnType = typeof(System.Collections.Generic.List`1<TMPro.TMP_Asset>))]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "IsEmoji", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "IsEmojiPresentationForm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_SpriteAsset), Member = "get_spriteCharacterTable", ReturnType = typeof(System.Collections.Generic.List`1<TMPro.TMP_SpriteCharacter>))]
	[Calls(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_TextInfo), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "get_textInfo", ReturnType = typeof(TMP_TextInfo))]
	[Calls(Type = typeof(char), Member = "IsUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000FA")]
	internal virtual int SetArraySizes(TextProcessingElement[] textProcessingArray) { }

	[Address(RVA = "0x187C330", Offset = "0x187B530", Length = "0x392")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60000F7")]
	protected virtual void SetCulling() { }

	[Address(RVA = "0x187C6D0", Offset = "0x187B8D0", Length = "0x19B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Material), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000F4")]
	protected virtual void SetFaceColor(Color32 color) { }

	[Address(RVA = "0x187C870", Offset = "0x187BA70", Length = "0xDB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000C9")]
	public virtual void SetLayoutDirty() { }

	[Address(RVA = "0x187C950", Offset = "0x187BB50", Length = "0xDC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "IsRebuildingGraphics", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000CA")]
	public virtual void SetMaterialDirty() { }

	[Address(RVA = "0x187CA30", Offset = "0x187BC30", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_MeshInfo), Member = "ResizeMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60000F9")]
	private void SetMeshArrays(int size) { }

	[Address(RVA = "0x187CAF0", Offset = "0x187BCF0", Length = "0x19B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Material), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000F5")]
	protected virtual void SetOutlineColor(Color32 color) { }

	[Address(RVA = "0x187CC90", Offset = "0x187BE90", Length = "0x227")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Material), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Texture))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000F3")]
	protected virtual void SetOutlineThickness(float thickness) { }

	[Address(RVA = "0x187CEC0", Offset = "0x187C0C0", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000F8")]
	private void SetPerspectiveCorrection() { }

	[Address(RVA = "0x187CF80", Offset = "0x187C180", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000F6")]
	protected virtual void SetShaderDepth() { }

	[Address(RVA = "0x187D030", Offset = "0x187C230", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F0")]
	protected virtual void SetSharedMaterial(Material mat) { }

	[Address(RVA = "0x187D090", Offset = "0x187C290", Length = "0x52F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Material), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Texture))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000F2")]
	protected virtual void SetSharedMaterials(Material[] materials) { }

	[Address(RVA = "0x187D5C0", Offset = "0x187C7C0", Length = "0xCF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "IsRebuildingGraphics", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000C8")]
	public virtual void SetVerticesDirty() { }

	[Address(RVA = "0x187D690", Offset = "0x187C890", Length = "0x1E9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Rect), Member = "Overlaps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CanvasRenderer), Member = "get_cull", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CanvasRenderer), Member = "set_cull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent`1), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000D6")]
	internal virtual void UpdateCulling() { }

	[Address(RVA = "0x187D880", Offset = "0x187CA80", Length = "0x2D8")]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "InternalUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Material), Member = "GetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Material), Member = "SetMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000EA")]
	private void UpdateEnvMapMatrix() { }

	[Address(RVA = "0x187DB60", Offset = "0x187CD60", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E2")]
	public void UpdateFontAsset() { }

	[Address(RVA = "0x187DB80", Offset = "0x187CD80", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds", ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60000DF")]
	public virtual void UpdateGeometry(Mesh mesh, int index) { }

	[Address(RVA = "0x187DC10", Offset = "0x187CE10", Length = "0x474")]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "set_maskOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "EnableMasking", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ShaderUtilities), Member = "GetShaderPropertyIDs", ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60000ED")]
	private void UpdateMask() { }

	[Address(RVA = "0x187E090", Offset = "0x187D290", Length = "0x15C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CanvasRenderer), Member = "set_materialCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000D1")]
	protected virtual void UpdateMaterial() { }

	[Address(RVA = "0x187E1F0", Offset = "0x187D3F0", Length = "0x123")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ShaderUtilities), Member = "GetPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ShaderUtilities), Member = "IsMaskingEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_SubMeshUI), Member = "UpdateMeshPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60000D7")]
	public virtual void UpdateMeshPadding() { }

	[Address(RVA = "0x187E320", Offset = "0x187D520", Length = "0x2AF")]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "InternalUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextMeshProUGUI), Member = "OnPreRenderCanvas", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_SubMeshUI), Member = "get_mesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000108")]
	private void UpdateSDFScale(float scaleDelta) { }

	[Address(RVA = "0x187E5D0", Offset = "0x187D7D0", Length = "0xF7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_SubMeshUI), Member = "SetPivotDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60000CF")]
	private void UpdateSubObjectPivot() { }

	[Address(RVA = "0x187E910", Offset = "0x187DB10", Length = "0x279")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_MeshInfo), Member = "ClearUnusedVertices", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_SubMeshUI), Member = "get_mesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Mesh), Member = "set_vertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_uv2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_colors32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds", ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60000E1")]
	public virtual void UpdateVertexData() { }

	[Address(RVA = "0x187E6D0", Offset = "0x187D8D0", Length = "0x23B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_SubMeshUI), Member = "get_mesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Mesh), Member = "set_vertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_uv2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "set_colors32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds", ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60000E0")]
	public virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	[Address(RVA = "0x187EB90", Offset = "0x187DD90", Length = "0x14D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Texture))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000E9")]
	private void ValidateEnvMapProperty() { }

}

