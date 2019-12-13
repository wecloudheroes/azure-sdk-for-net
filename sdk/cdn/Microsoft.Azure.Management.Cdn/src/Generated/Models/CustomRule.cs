// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the common attributes for a custom rule that can be included in
    /// a waf policy
    /// </summary>
    public partial class CustomRule
    {
        /// <summary>
        /// Initializes a new instance of the CustomRule class.
        /// </summary>
        public CustomRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CustomRule class.
        /// </summary>
        /// <param name="name">Defines the name of the custom rule</param>
        /// <param name="priority">Defines in what order this rule be evaluated
        /// in the overall list of custom rules</param>
        /// <param name="matchConditions">List of match conditions.</param>
        /// <param name="action">Describes what action to be applied when rule
        /// matches. Possible values include: 'Allow', 'Block', 'Log',
        /// 'Redirect'</param>
        /// <param name="enabledState">Describes if the custom rule is in
        /// enabled or disabled state. Defaults to Enabled if not specified.
        /// Possible values include: 'Disabled', 'Enabled'</param>
        public CustomRule(string name, int priority, IList<MatchCondition> matchConditions, string action, string enabledState = default(string))
        {
            Name = name;
            EnabledState = enabledState;
            Priority = priority;
            MatchConditions = matchConditions;
            Action = action;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets defines the name of the custom rule
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets describes if the custom rule is in enabled or disabled
        /// state. Defaults to Enabled if not specified. Possible values
        /// include: 'Disabled', 'Enabled'
        /// </summary>
        [JsonProperty(PropertyName = "enabledState")]
        public string EnabledState { get; set; }

        /// <summary>
        /// Gets or sets defines in what order this rule be evaluated in the
        /// overall list of custom rules
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public int Priority { get; set; }

        /// <summary>
        /// Gets or sets list of match conditions.
        /// </summary>
        [JsonProperty(PropertyName = "matchConditions")]
        public IList<MatchCondition> MatchConditions { get; set; }

        /// <summary>
        /// Gets or sets describes what action to be applied when rule matches.
        /// Possible values include: 'Allow', 'Block', 'Log', 'Redirect'
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (MatchConditions == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MatchConditions");
            }
            if (Action == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Action");
            }
            if (Priority > 1000)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Priority", 1000);
            }
            if (Priority < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Priority", 0);
            }
            if (MatchConditions != null)
            {
                foreach (var element in MatchConditions)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}