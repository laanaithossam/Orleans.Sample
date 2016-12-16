#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.1.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute("OrleanSilo.Interfaces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
namespace OrleanSilo.Interfaces
{
    using global::Orleans.Async;
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.1.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::OrleanSilo.Interfaces.IEmployee))]
    internal class OrleansCodeGenEmployeeReference : global::Orleans.Runtime.GrainReference, global::OrleanSilo.Interfaces.IEmployee
    {
        protected @OrleansCodeGenEmployeeReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenEmployeeReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 108671495;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::OrleanSilo.Interfaces.IEmployee";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 108671495;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 108671495:
                    switch (@methodId)
                    {
                        case -1319124596:
                            return "Greeting";
                        case 312402437:
                            return "GetLevel";
                        case -1461035780:
                            return "Promote";
                        case 940043127:
                            return "GetManager";
                        case -159913581:
                            return "SetManager";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 108671495 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @Greeting(global::OrleanSilo.Interfaces.IEmployee @from, global::System.String @message)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1319124596, new global::System.Object[]{@from is global::Orleans.Grain ? @from.@AsReference<global::OrleanSilo.Interfaces.IEmployee>() : @from, @message});
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> @GetLevel()
        {
            return base.@InvokeMethodAsync<global::System.Int32>(312402437, null);
        }

        public global::System.Threading.Tasks.Task @Promote(global::System.Int32 @newLevel)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1461035780, new global::System.Object[]{@newLevel});
        }

        public global::System.Threading.Tasks.Task<global::OrleanSilo.Interfaces.IManager> @GetManager()
        {
            return base.@InvokeMethodAsync<global::OrleanSilo.Interfaces.IManager>(940043127, null);
        }

        public global::System.Threading.Tasks.Task @SetManager(global::OrleanSilo.Interfaces.IManager @manager)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-159913581, new global::System.Object[]{@manager is global::Orleans.Grain ? @manager.@AsReference<global::OrleanSilo.Interfaces.IManager>() : @manager});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.1.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::OrleanSilo.Interfaces.IEmployee", 108671495, typeof (global::OrleanSilo.Interfaces.IEmployee)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenEmployeeMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            if (@grain == null)
                throw new global::System.ArgumentNullException("grain");
            switch (interfaceId)
            {
                case 108671495:
                    switch (methodId)
                    {
                        case -1319124596:
                            return ((global::OrleanSilo.Interfaces.IEmployee)@grain).@Greeting((global::OrleanSilo.Interfaces.IEmployee)arguments[0], (global::System.String)arguments[1]).@Box();
                        case 312402437:
                            return ((global::OrleanSilo.Interfaces.IEmployee)@grain).@GetLevel().@Box();
                        case -1461035780:
                            return ((global::OrleanSilo.Interfaces.IEmployee)@grain).@Promote((global::System.Int32)arguments[0]).@Box();
                        case 940043127:
                            return ((global::OrleanSilo.Interfaces.IEmployee)@grain).@GetManager().@Box();
                        case -159913581:
                            return ((global::OrleanSilo.Interfaces.IEmployee)@grain).@SetManager((global::OrleanSilo.Interfaces.IManager)arguments[0]).@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 108671495 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 108671495;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.1.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::OrleanSilo.Interfaces.IManager))]
    internal class OrleansCodeGenManagerReference : global::Orleans.Runtime.GrainReference, global::OrleanSilo.Interfaces.IManager
    {
        protected @OrleansCodeGenManagerReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenManagerReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 1915215068;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::OrleanSilo.Interfaces.IManager";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 1915215068;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 1915215068:
                    switch (@methodId)
                    {
                        case -1701259070:
                            return "AsEmployee";
                        case -675836216:
                            return "GetDirectReports";
                        case -1731443267:
                            return "AddDirectReport";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1915215068 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::OrleanSilo.Interfaces.IEmployee> @AsEmployee()
        {
            return base.@InvokeMethodAsync<global::OrleanSilo.Interfaces.IEmployee>(-1701259070, null);
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::OrleanSilo.Interfaces.IEmployee>> @GetDirectReports()
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.List<global::OrleanSilo.Interfaces.IEmployee>>(-675836216, null);
        }

        public global::System.Threading.Tasks.Task @AddDirectReport(global::OrleanSilo.Interfaces.IEmployee @employee)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1731443267, new global::System.Object[]{@employee is global::Orleans.Grain ? @employee.@AsReference<global::OrleanSilo.Interfaces.IEmployee>() : @employee});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.1.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::OrleanSilo.Interfaces.IManager", 1915215068, typeof (global::OrleanSilo.Interfaces.IManager)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenManagerMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            if (@grain == null)
                throw new global::System.ArgumentNullException("grain");
            switch (interfaceId)
            {
                case 1915215068:
                    switch (methodId)
                    {
                        case -1701259070:
                            return ((global::OrleanSilo.Interfaces.IManager)@grain).@AsEmployee().@Box();
                        case -675836216:
                            return ((global::OrleanSilo.Interfaces.IManager)@grain).@GetDirectReports().@Box();
                        case -1731443267:
                            return ((global::OrleanSilo.Interfaces.IManager)@grain).@AddDirectReport((global::OrleanSilo.Interfaces.IEmployee)arguments[0]).@Box();
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1915215068 + ",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 1915215068;
            }
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 649
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
