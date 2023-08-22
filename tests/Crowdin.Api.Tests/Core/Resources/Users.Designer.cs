﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Crowdin.Api.Tests.Core.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Users {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Users() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Crowdin.Api.Tests.Core.Resources.Users", typeof(Users).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;userIds&quot;: [
        ///    1
        ///  ],
        ///  &quot;accessToAllWorkflowSteps&quot;: false,
        ///  &quot;managerAccess&quot;: false,
        ///  &quot;permissions&quot;: {
        ///    &quot;it&quot;: {
        ///      &quot;workflowStepIds&quot;: [
        ///        313
        ///      ]
        ///    },
        ///    &quot;de&quot;: {
        ///      &quot;workflowStepIds&quot;: &quot;all&quot;
        ///    }
        ///  },
        ///  &quot;roles&quot;: [
        ///    {
        ///      &quot;name&quot;: &quot;translator&quot;,
        ///      &quot;permissions&quot;: {
        ///        &quot;allLanguages&quot;: false,
        ///        &quot;languagesAccess&quot;: {
        ///          &quot;uk&quot;: {
        ///            &quot;allContent&quot;: false,
        ///            &quot;workflowStepIds&quot;: [
        ///              882
        ///            ]
        ///          [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AddProjectMember_Request {
            get {
                return ResourceManager.GetString("AddProjectMember_Request", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;skipped&quot;: [
        ///    {
        ///      &quot;data&quot;: {
        ///        &quot;id&quot;: 1,
        ///        &quot;username&quot;: &quot;john_smith&quot;,
        ///        &quot;firstName&quot;: &quot;John&quot;,
        ///        &quot;lastName&quot;: &quot;Smith&quot;,
        ///        &quot;roles&quot;: [
        ///          {
        ///            &quot;name&quot;: &quot;translator&quot;,
        ///            &quot;permissions&quot;: {
        ///              &quot;allLanguages&quot;: false,
        ///              &quot;languagesAccess&quot;: {
        ///                &quot;uk&quot;: {
        ///                  &quot;allContent&quot;: false,
        ///                  &quot;workflowStepIds&quot;: [
        ///                    882
        ///                  ]
        ///                },
        ///              [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AddProjectMember_Response {
            get {
                return ResourceManager.GetString("AddProjectMember_Response", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [
        ///  {
        ///
        ///    &quot;path&quot;: &quot;/firstName&quot;,
        ///    &quot;op&quot;: &quot;replace&quot;,
        ///    &quot;value&quot;: &quot;Jonny&quot;
        ///  },
        ///  {
        ///
        ///    &quot;path&quot;: &quot;/status&quot;,
        ///    &quot;op&quot;: &quot;replace&quot;,
        ///    &quot;value&quot;: &quot;active&quot;
        ///  }
        ///].
        /// </summary>
        internal static string EditUser_Request {
            get {
                return ResourceManager.GetString("EditUser_Request", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;data&quot;: {
        ///    &quot;id&quot;: 1,
        ///    &quot;username&quot;: &quot;john_smith&quot;,
        ///    &quot;email&quot;: &quot;jsmith@example.com&quot;,
        ///    &quot;firstName&quot;: &quot;John&quot;,
        ///    &quot;lastName&quot;: &quot;Smith&quot;,
        ///    &quot;status&quot;: &quot;active&quot;,
        ///    &quot;avatarUrl&quot;: &quot;&quot;,
        ///    &quot;createdAt&quot;: &quot;2019-07-11T07:40:22+00:00&quot;,
        ///    &quot;lastSeen&quot;: &quot;2019-10-23T11:44:02+00:00&quot;,
        ///    &quot;twoFactor&quot;: &quot;enabled&quot;,
        ///    &quot;isAdmin&quot;: true,
        ///    &quot;timezone&quot;: &quot;Europe/Kiev&quot;
        ///  }
        ///}.
        /// </summary>
        internal static string EditUser_Response {
            get {
                return ResourceManager.GetString("EditUser_Response", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;data&quot;: {
        ///    &quot;id&quot;: 1,
        ///    &quot;username&quot;: &quot;john_smith&quot;,
        ///    &quot;firstName&quot;: &quot;John&quot;,
        ///    &quot;lastName&quot;: &quot;Smith&quot;,
        ///    &quot;roles&quot;: [
        ///      {
        ///        &quot;name&quot;: &quot;translator&quot;,
        ///        &quot;permissions&quot;: {
        ///          &quot;allLanguages&quot;: false,
        ///          &quot;languagesAccess&quot;: {
        ///            &quot;uk&quot;: {
        ///              &quot;allContent&quot;: false,
        ///              &quot;workflowStepIds&quot;: [
        ///                882
        ///              ]
        ///            },
        ///            &quot;it&quot;: {
        ///              &quot;allContent&quot;: true
        ///            }
        ///          }
        ///        }
        ///      },
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GetProjectMemberPermissions_Response {
            get {
                return ResourceManager.GetString("GetProjectMemberPermissions_Response", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;email&quot;: &quot;john@example.com&quot;,
        ///  &quot;firstName&quot;: &quot;Jon&quot;,
        ///  &quot;lastName&quot;: &quot;Doe&quot;,
        ///  &quot;timezone&quot;: &quot;America/New_York&quot;,
        ///  &quot;adminAccess&quot;: true
        ///}.
        /// </summary>
        internal static string InviteUser_Request {
            get {
                return ResourceManager.GetString("InviteUser_Request", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;data&quot;: {
        ///    &quot;id&quot;: 1,
        ///    &quot;username&quot;: &quot;john_smith&quot;,
        ///    &quot;email&quot;: &quot;jsmith@example.com&quot;,
        ///    &quot;firstName&quot;: &quot;John&quot;,
        ///    &quot;lastName&quot;: &quot;Smith&quot;,
        ///    &quot;status&quot;: &quot;active&quot;,
        ///    &quot;avatarUrl&quot;: &quot;&quot;,
        ///    &quot;createdAt&quot;: &quot;2019-07-11T07:40:22+00:00&quot;,
        ///    &quot;lastSeen&quot;: &quot;2019-10-23T11:44:02+00:00&quot;,
        ///    &quot;twoFactor&quot;: &quot;enabled&quot;,
        ///    &quot;isAdmin&quot;: true,
        ///    &quot;timezone&quot;: &quot;Europe/Kiev&quot;
        ///  }
        ///}.
        /// </summary>
        internal static string InviteUser_Response {
            get {
                return ResourceManager.GetString("InviteUser_Response", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;data&quot;: [
        ///    {
        ///      &quot;data&quot;: {
        ///        &quot;id&quot;: 1,
        ///        &quot;username&quot;: &quot;john_smith&quot;,
        ///        &quot;firstName&quot;: &quot;John&quot;,
        ///        &quot;lastName&quot;: &quot;Smith&quot;,
        ///        &quot;roles&quot;: [
        ///          {
        ///            &quot;name&quot;: &quot;translator&quot;,
        ///            &quot;permissions&quot;: {
        ///              &quot;allLanguages&quot;: false,
        ///              &quot;languagesAccess&quot;: {
        ///                &quot;uk&quot;: {
        ///                  &quot;allContent&quot;: false,
        ///                  &quot;workflowStepIds&quot;: [
        ///                    882
        ///                  ]
        ///                },
        ///                 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ListProjectMembers_Response {
            get {
                return ResourceManager.GetString("ListProjectMembers_Response", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;accessToAllWorkflowSteps&quot;: false,
        ///  &quot;managerAccess&quot;: false,
        ///  &quot;permissions&quot;: {
        ///    &quot;it&quot;: {
        ///      &quot;workflowStepIds&quot;: [
        ///        313
        ///      ]
        ///    },
        ///    &quot;de&quot;: {
        ///      &quot;workflowStepIds&quot;: &quot;all&quot;
        ///    }
        ///  },
        ///  &quot;roles&quot;: [
        ///    {
        ///      &quot;name&quot;: &quot;translator&quot;,
        ///      &quot;permissions&quot;: {
        ///        &quot;allLanguages&quot;: false,
        ///        &quot;languagesAccess&quot;: {
        ///          &quot;uk&quot;: {
        ///            &quot;allContent&quot;: false,
        ///            &quot;workflowStepIds&quot;: [
        ///              882
        ///            ]
        ///          },
        ///          &quot;it&quot;: {
        ///      [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ReplaceProjectMemberPermissions_Request {
            get {
                return ResourceManager.GetString("ReplaceProjectMemberPermissions_Request", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;data&quot;: {
        ///    &quot;id&quot;: 1,
        ///    &quot;username&quot;: &quot;john_smith&quot;,
        ///    &quot;firstName&quot;: &quot;John&quot;,
        ///    &quot;lastName&quot;: &quot;Smith&quot;,
        ///    &quot;roles&quot;: [
        ///      {
        ///        &quot;name&quot;: &quot;translator&quot;,
        ///        &quot;permissions&quot;: {
        ///          &quot;allLanguages&quot;: false,
        ///          &quot;languagesAccess&quot;: {
        ///            &quot;uk&quot;: {
        ///              &quot;allContent&quot;: false,
        ///              &quot;workflowStepIds&quot;: [
        ///                882
        ///              ]
        ///            },
        ///            &quot;it&quot;: {
        ///              &quot;allContent&quot;: true
        ///            }
        ///          }
        ///        }
        ///      },
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ReplaceProjectMemberPermissions_Response {
            get {
                return ResourceManager.GetString("ReplaceProjectMemberPermissions_Response", resourceCulture);
            }
        }
    }
}
