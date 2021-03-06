//---------------------------------------------------------------------
// Authors: jachymko
//
// Description: Class implementing Get-Junction command.
//
// Creation Date: Dec 15, 2006
//---------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Management.Automation;

using Microsoft.PowerShell.Commands;
using Pscx.IO;
using Pscx.IO.Ntfs;

namespace Pscx.Commands.IO.Ntfs
{
    [Cmdlet(VerbsCommon.Get, PscxNouns.ReparsePoint, DefaultParameterSetName = ParameterSetPath)]
    [Description("Gets NTFS reparse point data.")]
    [RelatedLink(typeof(NewHardLinkCommand)), 
     RelatedLink(typeof(NewJunctionCommand)),
     RelatedLink(typeof(GetMountPointCommand)), 
     RelatedLink(typeof(RemoveMountPointCommand)),
     RelatedLink(typeof(RemoveReparsePointCommand)), 
     RelatedLink(typeof(NewSymlinkCommand))]
    [ProviderConstraint(typeof(FileSystemProvider))]
    public sealed class GetReparsePointCommand : PscxPathCommandBase
    {
        [Parameter(HelpMessage = "When specified, gets the raw reparse point data as a byte array.")]
        public SwitchParameter Raw
        {
            get;
            set;
        }

        protected override void ProcessPath(PscxPathInfo pscxPath)
        {
            var filePath = pscxPath.ProviderPath;

            if (ReparsePointHelper.IsReparsePoint(filePath))
            {
                if (Raw)
                {
                    WriteObject(ReparsePointHelper.GetReparsePointData(filePath));
                }
                else
                {
                    WriteObject(ReparsePointHelper.GetReparsePoint(filePath));
                }
            }
        }
    }
}
