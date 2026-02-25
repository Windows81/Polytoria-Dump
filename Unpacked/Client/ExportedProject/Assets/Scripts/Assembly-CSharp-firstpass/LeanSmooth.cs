//Type is in global namespace

[Token(Token = "0x2000008")]
public class LeanSmooth
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000035")]
	public LeanSmooth() { }

	[Address(RVA = "0x2C4D60", Offset = "0x2C3F60", Length = "0x111")]
	[CalledBy(Type = typeof(LeanSmooth), Member = "bounceOut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3&), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(LeanSmooth), Member = "bounceOut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color), typeof(Color&), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(Color))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass195_0", Member = "<followBounceOut>b__2", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass195_0", Member = "<followBounceOut>b__3", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass195_0", Member = "<followBounceOut>b__4", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass195_0", Member = "<followBounceOut>b__5", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass195_0", Member = "<followBounceOut>b__6", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass195_0", Member = "<followBounceOut>b__7", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass195_0", Member = "<followBounceOut>b__9", ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[Token(Token = "0x6000032")]
	public static float bounceOut(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed = -1, float deltaTime = -1, float friction = 2, float accelRate = 0.5, float hitDamping = 0.9) { }

	[Address(RVA = "0x2C49C0", Offset = "0x2C3BC0", Length = "0x19E")]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass195_0", Member = "<followBounceOut>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass195_0", Member = "<followBounceOut>b__1", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass195_0", Member = "<followBounceOut>b__8", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LeanSmooth), Member = "bounceOut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Single&), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Token(Token = "0x6000033")]
	public static Vector3 bounceOut(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed = -1, float deltaTime = -1, float friction = 2, float accelRate = 0.5, float hitDamping = 0.9) { }

	[Address(RVA = "0x2C4B60", Offset = "0x2C3D60", Length = "0x1FB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LeanSmooth), Member = "bounceOut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Single&), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Token(Token = "0x6000034")]
	public static Color bounceOut(Color current, Color target, ref Color currentVelocity, float smoothTime, float maxSpeed = -1, float deltaTime = -1, float friction = 2, float accelRate = 0.5, float hitDamping = 0.9) { }

	[Address(RVA = "0x2C4FB0", Offset = "0x2C41B0", Length = "0x177")]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass193_0", Member = "<followDamp>b__3", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass193_0", Member = "<followDamp>b__9", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LeanSmooth), Member = "damp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3&), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(LeanSmooth), Member = "damp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color), typeof(Color&), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(Color))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass193_0", Member = "<followDamp>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass193_0", Member = "<followDamp>b__1", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass193_0", Member = "<followDamp>b__2", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass193_0", Member = "<followDamp>b__4", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass193_0", Member = "<followDamp>b__5", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass193_0", Member = "<followDamp>b__6", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass193_0", Member = "<followDamp>b__7", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass193_0", Member = "<followDamp>b__8", ReturnType = typeof(void))]
	[CallerCount(Count = 26)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000029")]
	public static float damp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed = -1, float deltaTime = -1) { }

	[Address(RVA = "0x2C4E80", Offset = "0x2C4080", Length = "0x121")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LeanSmooth), Member = "damp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Single&), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Token(Token = "0x600002A")]
	public static Vector3 damp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed = -1, float deltaTime = -1) { }

	[Address(RVA = "0x2C5130", Offset = "0x2C4330", Length = "0x166")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LeanSmooth), Member = "damp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Single&), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Token(Token = "0x600002B")]
	public static Color damp(Color current, Color target, ref Color currentVelocity, float smoothTime, float maxSpeed = -1, float deltaTime = -1) { }

	[Address(RVA = "0x2C53B0", Offset = "0x2C45B0", Length = "0x91")]
	[CalledBy(Type = typeof(LeanSmooth), Member = "linear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(LeanSmooth), Member = "linear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color), typeof(float)}, ReturnType = typeof(Color))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass196_0", Member = "<followLinear>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass196_0", Member = "<followLinear>b__1", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass196_0", Member = "<followLinear>b__2", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass196_0", Member = "<followLinear>b__3", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass196_0", Member = "<followLinear>b__4", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass196_0", Member = "<followLinear>b__5", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass196_0", Member = "<followLinear>b__6", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass196_0", Member = "<followLinear>b__7", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass196_0", Member = "<followLinear>b__8", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass196_0", Member = "<followLinear>b__9", ReturnType = typeof(void))]
	[CallerCount(Count = 26)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[Token(Token = "0x600002F")]
	public static float linear(float current, float target, float moveSpeed, float deltaTime = -1) { }

	[Address(RVA = "0x2C5450", Offset = "0x2C4650", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LeanSmooth), Member = "linear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Token(Token = "0x6000030")]
	public static Vector3 linear(Vector3 current, Vector3 target, float moveSpeed, float deltaTime = -1) { }

	[Address(RVA = "0x2C52A0", Offset = "0x2C44A0", Length = "0x107")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LeanSmooth), Member = "linear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Token(Token = "0x6000031")]
	public static Color linear(Color current, Color target, float moveSpeed) { }

	[Address(RVA = "0x2C5530", Offset = "0x2C4730", Length = "0xD9")]
	[CalledBy(Type = typeof(LeanSmooth), Member = "spring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3&), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(LeanSmooth), Member = "spring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color), typeof(Color&), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(Color))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass194_0", Member = "<followSpring>b__2", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass194_0", Member = "<followSpring>b__3", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass194_0", Member = "<followSpring>b__4", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass194_0", Member = "<followSpring>b__5", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass194_0", Member = "<followSpring>b__6", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass194_0", Member = "<followSpring>b__7", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass194_0", Member = "<followSpring>b__9", ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[Token(Token = "0x600002C")]
	public static float spring(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed = -1, float deltaTime = -1, float friction = 2, float accelRate = 0.5) { }

	[Address(RVA = "0x2C5610", Offset = "0x2C4810", Length = "0x174")]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass194_0", Member = "<followSpring>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass194_0", Member = "<followSpring>b__1", ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween+<>c__DisplayClass194_0", Member = "<followSpring>b__8", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LeanSmooth), Member = "spring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Single&), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Token(Token = "0x600002D")]
	public static Vector3 spring(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed = -1, float deltaTime = -1, float friction = 2, float accelRate = 0.5) { }

	[Address(RVA = "0x2C5790", Offset = "0x2C4990", Length = "0x1C9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LeanSmooth), Member = "spring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Single&), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Token(Token = "0x600002E")]
	public static Color spring(Color current, Color target, ref Color currentVelocity, float smoothTime, float maxSpeed = -1, float deltaTime = -1, float friction = 2, float accelRate = 0.5) { }

}

