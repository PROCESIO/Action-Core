using Ringhel.Procesio.Action.Core.Utils;

namespace Ringhel.Procesio.Action.Core.ActionDecorators;

/// <summary>
/// Attribute used to set some vital information for FE
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, AllowMultiple = true)]
public class FEDecoratorAttribute : Attribute
{
    /// <summary>
    /// The parent tab to which the current property belongs
    /// </summary>
    public string Tab { get; set; }

    /// <summary>
    /// The parent property to which the current property belongs
    /// </summary>
    public string Parent { get; set; }

    /// <summary>
    /// Property label
    /// </summary>
    public string Label { get; set; }

    /// <summary>
    /// Name of the options list
    /// Each FE component may have a list of options
    /// </summary>
    public string Options { get; set; }

    /// <summary>
    /// The property default value converted to String
    /// </summary>
    public object DefaultValue { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public FeComponentType Type { get; set; }

    /// <summary>
    /// Set different text formats: SQL, JSON, PLAINTEXT, etc.
    /// </summary>
    public FeTextFormat TextFormat { get; set; } = FeTextFormat.NONE;

    /// <summary>
    /// Property Row number. Used when showing the property in the Action configuration panel.
    /// If not set, all properties will be placed on the same default row.
    /// </summary>
    public int RowId { get; set; } = 0;

    /// <summary>
    /// Property Column number. Used to define the order/position of properties within the same row.
    /// Properties with the same RowId will be ordered by their ColumnId value.
    /// If not set, properties will be displayed on different rows.
    /// </summary>
    public int ColumnId { get; set; } = 0;

    /// <summary>
    /// Property Column size. Used when displaying more than one property on the same row.
    /// Uses a 12-column grid system where the sum of all ColumnSize values on the same row should equal 12.
    /// For example: two properties can use sizes 3 and 9, or 6 and 6, or 4 and 8, etc.
    /// If not set, properties sharing the same row will be split equally.
    /// </summary>
    public int ColumnSize { get; set; } = 0;

    /// <summary>
    /// Tooltip property.
    /// </summary>
    public string Tooltip { get; set; }

    /// <summary>
    /// Minimum allowed value of the current type
    /// </summary>
    public object Min { get; set; }

    /// <summary>
    /// Maximum allowed value of the current type
    /// </summary>
    public object Max { get; set; }

    /// <summary>
    /// If the property is of type Custom_Credential, we have to add its Type Guid.
    /// The Guid can be taken from the panel when creating an instance of the CustomCredentialType
    /// </summary>
    public string CustomCredentialsTypeGuid { get; set; }

    /// <summary>
    /// Credential components only. Values that prefill the New Credential form when the user presses
    /// Create Credential on this property in the designer. The user can still change every value.
    /// A JSON object, written as a literal or as the nameof of a const string field on the action:
    /// <code>
    /// {
    ///   "connectorType": "HubSpot",
    ///   "properties": {
    ///     "URL": "https://api.hubapi.com",
    ///     "AuthenticationMethod": "OAuth2",
    ///     "Scopes": ["crm.objects.contacts.read"]
    ///   }
    /// }
    /// </code>
    /// connectorType (optional, 1 to 50 characters) becomes the label of a credential created from this property,
    /// and the credential dropdown then lists only credentials that carry that label.
    /// The keys under properties are the be_id values of the credential template's fields; a radio or select is
    /// set by the option's be_value. A value is a string, a number, a boolean, or an array of strings. The whole
    /// JSON is at most 4096 characters.
    /// Never put a secret here (a password, an API key value, a client secret, a certificate password): the value
    /// is stored and served unencrypted with the action template, and the upload is refused for a protected key.
    /// The platform computes OAuthRedirectUrl from the new credential, so a default for it is ignored.
    /// </summary>
    public string CredentialDefaults { get; set; }
}
