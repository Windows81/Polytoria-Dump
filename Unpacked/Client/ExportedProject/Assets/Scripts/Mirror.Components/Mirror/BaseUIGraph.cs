namespace Mirror;

[Token(Token = "0x2000041")]
public abstract class BaseUIGraph : MonoBehaviour
{
	[Token(Token = "0x400016C")]
	private static readonly int MaxValue; //Field offset: 0x0
	[Token(Token = "0x400016D")]
	private static readonly int GraphData; //Field offset: 0x4
	[Token(Token = "0x400016E")]
	private static readonly int CategoryCount; //Field offset: 0x8
	[Token(Token = "0x400016F")]
	private static readonly int Colors; //Field offset: 0xC
	[Token(Token = "0x4000170")]
	private static readonly int Width; //Field offset: 0x10
	[Token(Token = "0x4000171")]
	private static readonly int DataStart; //Field offset: 0x14
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000172")]
	public Material Material; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000173")]
	public Graphic Renderer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Range(1, 64)]
	[Token(Token = "0x4000174")]
	public int Points; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000175")]
	public float SecondsPerPoint; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000176")]
	public Color[] CategoryColors; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000177")]
	public bool IsStacked; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000178")]
	public Text[] LegendTexts; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Header("Diagnostics")]
	[ReadOnly]
	[SerializeField]
	[Token(Token = "0x4000179")]
	private Material runtimeMaterial; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400017A")]
	private Single[] graphData; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400017B")]
	private int graphDataStartIndex; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400017C")]
	private bool isGraphDataDirty; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400017D")]
	private Single[] aggregatingData; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400017E")]
	private GraphAggregationMode[] aggregatingModes; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400017F")]
	private Int32[] aggregatingDataCounts; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000180")]
	private float aggregatingTime; //Field offset: 0x80

	[Token(Token = "0x17000024")]
	private int DataLastIndex
	{
		[Address(RVA = "0x122B690", Offset = "0x122A890", Length = "0x11")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000230")]
		private get { } //Length: 17
	}

	[Address(RVA = "0x122B4D0", Offset = "0x122A6D0", Length = "0x126")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Token(Token = "0x600023C")]
	private static BaseUIGraph() { }

	[Address(RVA = "0x122B600", Offset = "0x122A800", Length = "0x85")]
	[CalledBy(Type = typeof(FpsMinMaxAvgGraph), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkBandwidthGraph), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkPingGraph), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600023B")]
	protected BaseUIGraph() { }

	[Address(RVA = "0x122A9C0", Offset = "0x1229BC0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180289280")]
	[Token(Token = "0x600023A")]
	protected override float AdjustMaxValue(float max) { }

	[Address(RVA = "0x122A9D0", Offset = "0x1229BD0", Length = "0x185")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000231")]
	private void Awake() { }

	[Address(RVA = "0x122AB60", Offset = "0x1229D60", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000238")]
	private void ClearDataAt(int i) { }

	[Token(Token = "0x6000236")]
	protected abstract void CollectData(int category, out float value, out GraphAggregationMode mode) { }

	[Address(RVA = "0x122ABE0", Offset = "0x1229DE0", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000235")]
	protected override string FormatValue(float value) { }

	[Address(RVA = "0x122B690", Offset = "0x122A890", Length = "0x11")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000230")]
	private int get_DataLastIndex() { }

	[Address(RVA = "0x122AC40", Offset = "0x1229E40", Length = "0x332")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Material), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetFloatArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Single[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetColorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Color[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000239")]
	public void LateUpdate() { }

	[Address(RVA = "0x122AF80", Offset = "0x122A180", Length = "0x89")]
	[CalledBy(Type = typeof(FpsMinMaxAvgGraph), Member = "OnValidate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkBandwidthGraph), Member = "OnValidate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkPingGraph), Member = "OnValidate", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000232")]
	protected override void OnValidate() { }

	[Address(RVA = "0x122B010", Offset = "0x122A210", Length = "0x7F")]
	[CalledBy(Type = typeof(BaseUIGraph), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000234")]
	private void ResetCurrent(int i) { }

	[Address(RVA = "0x122B090", Offset = "0x122A290", Length = "0x51")]
	[CalledBy(Type = typeof(BaseUIGraph), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000237")]
	private void SetCurrentGraphData(int c, float value) { }

	[Address(RVA = "0x122B0F0", Offset = "0x122A2F0", Length = "0x3D1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseUIGraph), Member = "ResetCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(BaseUIGraph), Member = "SetCurrentGraphData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000233")]
	protected override void Update() { }

}

