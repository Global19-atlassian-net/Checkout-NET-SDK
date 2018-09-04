// This class was generated on Tue, 04 Sep 2018 12:18:45 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// Payee.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/+xXX28bNwx/36cg7ikBXLv/0gc/rXUKLBiWBV22ly4waIn2CdFRKiXFuQ357oN058RnJ0W2ddmw7cXAkaJI/vgjaf1anbeeqml1hi1RNap+QjG4sHSKTRZXo+pbau8+jikoMT4ax9W0Oq8JGhJVI0dY1w6EFJkrChBrgmViHQBZwzLZpbG2EzvRJGMY2JoAaIODS3ZrBuwO+hzSuBpVb0Ww7eJ8Pqo+EOrv2bbVdIk2UBZ8SkZI3wrOxHmSaChU04+3GYYohlf7KSpriOPc6EGu29L9pH1aWKPAaOJoloYElk4AvQclhJE0LNqSwybDSZcMnHAUp5MiDdFBSN47iZACgcJAAQ7yPTRejeGdoOFzIQLDkVaC2T2sTazhDNsztIewrkl6mIAaNHaOWguFAE5uPc+NzvCyi4BXaGzO/M+Cysnam9EtsscmeIttvhm+25T0hJdOmhL1Pua6s5hrjDiAfUfxGbqZu/sfTyZ46z2hhAx+lqoUomtIwDComtSlS3EEUZADqnx1GHXIdsz2MYwKobdOQG1CdNL+9URdCLKec/7Yhmwg3gcsK8AtB2x8JA4e24Y4/j147HDsQVBSMEwhzEtYQ2B2Vfvg5NYSLiRCa34h3WfX99H45/T8+Su1sE5dfkouUvnuflWI4njVSU5dpGknnmzL4UefIX7zGlSNgiqSBEAhQGvdOo8JWrr8yRpeHh09dAqXkaQUqvOhnO5D+bp3eieBYFY8hm/cmq5IRsVqRUyC1raASpHP86nBa9OkBizxKtbd+OJh9rmRXh5th941mseYUYMrkjz7cn9hzNaJC0j6sVECXZsQNyhPdmH+sgQ6qx3TZ/jje/09/Nmo7tkDWQOcmkWG2jCYGEAhOzYK7ZBe8PH9+MWb1/1pwyvwFhm6KXZxUMfow3QyWa/XYxPT2HCcCKnJ+bMP72fPiumE+PAJ9qFLHKWd52INV+JQsY9GfwAUWpvzywfhYDY7fCJooAuiWRgmvWF2P/pms25QlYnYe+3cQZNCLPtxQbAq6zv3GjK8OAJtVib2vN+1U45D5m92gXdaTSGa7qtH4PR4dli8h7TImGXj/o6DH05/X0mjpD82KOk6EgfjeN65HpT2HuV+eW8P9cE/0YTfAHtf3Pu6+xbgoGz/AC4+2Cf/aope3Fw8hqbb/2OHHN3R/L/N/8Pb/CH6bL16BuQZyvep0z2pyitB4OR4BOvaqLo8JaDBcEk6A1SGX9/EvQWq0s2bZskUZE26lCA/68qDLdZGNHgsuXSw79oFECoeFrYFYiVtKWymEoIX58VQRGnhKifMMYfxDgO9epltU+gelMSlnXN8QiHZ+EVm9MXNV78BAAD//w==
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace CheckoutNetsdk.Orders
{
    /// <summary>
    /// The merchant who receives the funds and fulfills the order. The merchant is also known as the payee.
    /// </summary>
    [DataContract]
    public class Payee
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Payee() {}

        /// <summary>
        /// The public identifier for app created by the merchant/payee. Introduced to support use cases (for e.g. BrainTree integration with PayPal) where payee email_address or merchant_id is not available.
        /// </summary>
        [DataMember(Name="client_id", EmitDefaultValue = false)]
        public string ClientId;

        /// <summary>
        /// The merchant information. The merchant is also known as the payee. Appears to the customer in checkout, transactions, email receipts, and transaction history.
        /// </summary>
        [DataMember(Name="display_data", EmitDefaultValue = false)]
        public DisplayableMerchantInformation DisplayData;

        /// <summary>
        /// The internationalized email address.<blockquote><strong>Note:</strong> Up to 64 characters are allowed before and 255 characters are allowed after the <code>@</code> sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted <code>@</code> sign exists.</blockquote>
        /// </summary>
        [DataMember(Name="email_address", EmitDefaultValue = false)]
        public string EmailAddress;

        /// <summary>
        /// The PayPal payer ID, which is a masked version of the PayPal account number intended for use with third parties. The account number is reversibly encrypted and a proprietary variant of Base32 is used to encode the result.
        /// </summary>
        [DataMember(Name="merchant_id", EmitDefaultValue = false)]
        public string MerchantId;
    }
}

