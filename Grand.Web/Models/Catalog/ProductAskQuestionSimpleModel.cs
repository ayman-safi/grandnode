﻿using FluentValidation.Attributes;
using Grand.Framework.Mvc.Models;
using Grand.Web.Validators.Catalog;
using Grand.Framework.Mvc.ModelBinding;

namespace Grand.Web.Models.Catalog
{
    [Validator(typeof(ProductAskQuestionSimpleValidator))]
    public partial class ProductAskQuestionSimpleModel: BaseGrandEntityModel
    {
        public string ProductId { get; set; }

        [GrandResourceDisplayName("Products.AskQuestion.Email")]
        public string AskQuestionEmail { get; set; }

        [GrandResourceDisplayName("Products.AskQuestion.FullName")]
        public string AskQuestionFullName { get; set; }

        [GrandResourceDisplayName("Products.AskQuestion.Phone")]
        public string AskQuestionPhone { get; set; }

        [GrandResourceDisplayName("Products.AskQuestion.Message")]
        public string AskQuestionMessage { get; set; }

        public bool DisplayCaptcha { get; set; }

    }
}