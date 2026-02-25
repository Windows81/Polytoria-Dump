namespace UnityEngine;

[MovedFrom("UnityEditor")]
[Token(Token = "0x2000107")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEditor.UIBuilderModule"})]
internal class NumericFieldDraggerUtility
{
	[Token(Token = "0x40004F3")]
	private static bool s_UseYSign; //Field offset: 0x0

	[Address(RVA = "0x19662D0", Offset = "0x19654D0", Length = "0x3F")]
	[CalledBy(Type = "UnityEngine.UIElements.DoubleField+DoubleInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(double)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.FloatField+FloatInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IntegerField+IntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.LongField+LongInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Slider", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.SliderInt", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UnsignedIntegerField+UnsignedIntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UnsignedLongField+UnsignedLongInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(ulong)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Token(Token = "0x6000852")]
	public static float Acceleration(bool shiftPressed, bool altPressed) { }

	[Address(RVA = "0x19663D0", Offset = "0x19655D0", Length = "0xB7")]
	[CalledBy(Type = "UnityEngine.UIElements.DoubleField+DoubleInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(double)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.FloatField+FloatInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Pow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000854")]
	public static double CalculateFloatDragSensitivity(double value) { }

	[Address(RVA = "0x1966310", Offset = "0x1965510", Length = "0xB6")]
	[CalledBy(Type = "UnityEngine.UIElements.Slider", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000855")]
	public static double CalculateFloatDragSensitivity(double value, double minValue, double maxValue) { }

	[Address(RVA = "0x1966490", Offset = "0x1965690", Length = "0x1D")]
	[CalledBy(Type = "UnityEngine.UIElements.IntegerField+IntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.LongField+LongInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UnsignedIntegerField+UnsignedIntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NumericFieldDraggerUtility), Member = "CalculateIntDragSensitivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000856")]
	public static long CalculateIntDragSensitivity(long value) { }

	[Address(RVA = "0x1966540", Offset = "0x1965740", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.UIElements.UnsignedLongField+UnsignedLongInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(ulong)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumericFieldDraggerUtility), Member = "CalculateIntDragSensitivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000857")]
	public static ulong CalculateIntDragSensitivity(ulong value) { }

	[Address(RVA = "0x19665C0", Offset = "0x19657C0", Length = "0x7B")]
	[CalledBy(Type = typeof(NumericFieldDraggerUtility), Member = "CalculateIntDragSensitivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(NumericFieldDraggerUtility), Member = "CalculateIntDragSensitivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(ulong))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Pow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000858")]
	public static double CalculateIntDragSensitivity(double value) { }

	[Address(RVA = "0x19664B0", Offset = "0x19656B0", Length = "0x82")]
	[CalledBy(Type = "UnityEngine.UIElements.SliderInt", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long)}, ReturnType = typeof(long))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000859")]
	public static long CalculateIntDragSensitivity(long value, long minValue, long maxValue) { }

	[Address(RVA = "0x1966640", Offset = "0x1965840", Length = "0x109")]
	[CalledBy(Type = "UnityEngine.UIElements.DoubleField+DoubleInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(double)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.FloatField+FloatInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IntegerField+IntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.LongField+LongInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Slider", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.SliderInt", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UnsignedIntegerField+UnsignedIntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UnsignedLongField+UnsignedLongInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(ulong)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AFC00")]
	[Token(Token = "0x6000853")]
	public static float NiceDelta(Vector2 deviceDelta, float acceleration) { }

}

