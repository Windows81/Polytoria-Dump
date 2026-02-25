namespace UnityEngine.UIElements;

[Token(Token = "0x20004EA")]
public abstract class UxmlSerializedData
{
	[Flags]
	[Token(Token = "0x20004EB")]
	internal enum UxmlAttributeFlags
	{
		Ignore = 0,
		OverriddenInUxml = 1,
		DefaultValue = 2,
	}

	[Token(Token = "0x4001026")]
	internal const string AttributeFlagSuffix = "_UxmlAttributeFlags"; //Field offset: 0x0
	[Token(Token = "0x4001027")]
	private const UxmlAttributeFlags k_DefaultFlags = 1; //Field offset: 0x0
	[Token(Token = "0x4001029")]
	private static UxmlAttributeFlags s_CurrentDeserializeFlags; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4001028")]
	[UxmlIgnore]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int uxmlAssetId; //Field offset: 0x10

	[Address(RVA = "0x1B52DA0", Offset = "0x1B51FA0", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6002451")]
	private static UxmlSerializedData() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002450")]
	protected UxmlSerializedData() { }

	[Token(Token = "0x600244E")]
	public abstract object CreateInstance() { }

	[Token(Token = "0x600244F")]
	public abstract void Deserialize(object obj) { }

}

