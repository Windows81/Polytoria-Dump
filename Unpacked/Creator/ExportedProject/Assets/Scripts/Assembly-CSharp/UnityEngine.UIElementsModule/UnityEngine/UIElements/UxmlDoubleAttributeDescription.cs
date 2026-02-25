namespace UnityEngine.UIElements;

[Token(Token = "0x20004C3")]
public class UxmlDoubleAttributeDescription : TypedUxmlAttributeDescription<Double>
{
	[CompilerGenerated]
	[Token(Token = "0x20004C4")]
	private sealed class <>c
	{
		[Token(Token = "0x4000FFB")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000FFC")]
		public static Func<String, Double, Double> <>9__3_0; //Field offset: 0x8

		[Address(RVA = "0x1B44970", Offset = "0x1B43B70", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60023DE")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60023DF")]
		public <>c() { }

		[Address(RVA = "0x1B43D90", Offset = "0x1B42F90", Length = "0x98")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Double&)}, ReturnType = typeof(bool))]
		[Token(Token = "0x60023E0")]
		internal double <GetValueFromBag>b__3_0(string s, double d) { }

	}


	[Address(RVA = "0x1B50CB0", Offset = "0x1B4FEB0", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TypedUxmlAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60023DB")]
	public UxmlDoubleAttributeDescription() { }

	[Address(RVA = "0x1B50A90", Offset = "0x1B4FC90", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Double&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60023DD")]
	private static double ConvertValueToDouble(string v, double defaultValue) { }

	[Address(RVA = "0x1B50B30", Offset = "0x1B4FD30", Length = "0x17A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UxmlAttributeDescription), Member = "GetValueFromBag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), typeof(System.Func`3<System.String, System.Double, System.Double>), typeof(double)}, ReturnType = typeof(double))]
	[Token(Token = "0x60023DC")]
	public virtual double GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

}

