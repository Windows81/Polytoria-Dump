namespace System;

[ClassInterface(ClassInterfaceType::AutoDual (2))]
[ComVisible(True)]
[Token(Token = "0x20001BD")]
public class object
{

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x6000F9B")]
	public Object() { }

	[Address(RVA = "0x2D8A50", Offset = "0x2D7C50", Length = "0x7")]
	[CallerCount(Count = 1453)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F99")]
	public override bool Equals(object obj) { }

	[Address(RVA = "0x13B6D10", Offset = "0x13B5F10", Length = "0x29")]
	[CallerCount(Count = 216)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F9A")]
	public static bool Equals(object objA, object objB) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FA3")]
	private void FieldGetter(string typeName, string fieldName, ref object val) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FA4")]
	private void FieldSetter(string typeName, string fieldName, object val) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000F9C")]
	protected override void Finalize() { }

	[Address(RVA = "0x14FBB70", Offset = "0x14FAD70", Length = "0x5")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802141F0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F9D")]
	public override int GetHashCode() { }

	[Address(RVA = "0x14FBB80", Offset = "0x14FAD80", Length = "0x5")]
	[CallerCount(Count = 618)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214040")]
	[Token(Token = "0x6000F9E")]
	public Type GetType() { }

	[Address(RVA = "0x14FBB70", Offset = "0x14FAD70", Length = "0x5")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802141F0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FA2")]
	internal static int InternalGetHashCode(object o) { }

	[Address(RVA = "0x14F2980", Offset = "0x14F1B80", Length = "0x5")]
	[CallerCount(Count = 36)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802143C0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F9F")]
	protected object MemberwiseClone() { }

	[Address(RVA = "0x2D8A50", Offset = "0x2D7C50", Length = "0x7")]
	[CallerCount(Count = 1453)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000FA1")]
	public static bool ReferenceEquals(object objA, object objB) { }

	[Address(RVA = "0x14FBB90", Offset = "0x14FAD90", Length = "0x2E")]
	[CalledBy(Type = typeof(X509Certificate), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Assembly), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(AssemblyName), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.Events.UnityEventBase", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.GUIContent", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214040")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FA0")]
	public override string ToString() { }

}

