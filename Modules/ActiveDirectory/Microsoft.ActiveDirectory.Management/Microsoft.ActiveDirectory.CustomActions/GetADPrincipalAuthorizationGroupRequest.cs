using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;

namespace Microsoft.ActiveDirectory.CustomActions
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "3.0.0.0")]
	[MessageContract(WrapperName="GetADPrincipalAuthorizationGroupRequest", WrapperNamespace="http://schemas.microsoft.com/2008/1/ActiveDirectory/CustomActions", IsWrapped=true)]
	internal class GetADPrincipalAuthorizationGroupRequest
	{
		[MessageHeader(Namespace="http://schemas.microsoft.com/2008/1/ActiveDirectory/CustomActions")]
		public string Server;

		[MessageBodyMember(Namespace="http://schemas.microsoft.com/2008/1/ActiveDirectory/CustomActions", Order=0)]
		public string PartitionDN;

		[MessageBodyMember(Namespace="http://schemas.microsoft.com/2008/1/ActiveDirectory/CustomActions", Order=1)]
		public string PrincipalDN;

		public GetADPrincipalAuthorizationGroupRequest()
		{
		}

		public GetADPrincipalAuthorizationGroupRequest(string Server, string PartitionDN, string PrincipalDN)
		{
			this.Server = Server;
			this.PartitionDN = PartitionDN;
			this.PrincipalDN = PrincipalDN;
		}
	}
}