using OT.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace OT.Data.Test.Basic
{
    [Binding]
    public class QuestionSteps
    {
        const string  QuestionTitle = "QuestionTitle";
        const string OptionTitleA = "OptionTitleA";
        const string OptionTitleB = "OptionTitleB";
        const string OptionTitleC = "OptionTitleC";
        const string OptionTitleD = "OptionTitleD";
        const string AnswerTitle = "AnswerTitle";

        public Repository Repository { get; set; }

        public QuestionSteps()
        {
            Repository = new Repository();
        }

        [Given(@"I have Question (.*)")]
        public void GivenIHaveQuestion(string questionTitle)
        {
            ScenarioContext.Current[QuestionTitle] = questionTitle;
        }

        [Given(@"I have OptionA (.*)")]
        public void GivenIHaveOptionA(string optionTitle)
        {
            ScenarioContext.Current[OptionTitleA] = optionTitle;
        }
        [Given(@"I have OptionB (.*)")]
        public void GivenIHaveOptionB(string optionTitle)
        {
            ScenarioContext.Current[OptionTitleB] = optionTitle;
        }
        [Given(@"I have OptionC (.*)")]
        public void GivenIHaveOptionC(string optionTitle)
        {
            ScenarioContext.Current[OptionTitleC] = optionTitle;
        }
        [Given(@"I have OptionD (.*)")]
        public void GivenIHaveOptionD(string optionTitle)
        {
            ScenarioContext.Current[OptionTitleD] = optionTitle;
        }

        [Given(@"I have Answer (.*)")]
        public void GivenIHaveAnswerToGetIntoAProperty(string answerTitle)
        {
            ScenarioContext.Current[AnswerTitle] = answerTitle;
        }

        [Given(@"I Save it")]
        public void GivenISaveIt()
        {
            var question = new Question
            {
                Title = ScenarioContext.Current[QuestionTitle].ToString(),
                Options = new List<Answer>
                {
                    new Answer {Title =  ScenarioContext.Current[OptionTitleA].ToString() },
                    new Answer {Title =  ScenarioContext.Current[OptionTitleB].ToString() },
                    new Answer {Title =  ScenarioContext.Current[OptionTitleC].ToString() },
                    new Answer {Title =  ScenarioContext.Current[OptionTitleD].ToString() }
                },
                Answer = new Answer { Title = ScenarioContext.Current[AnswerTitle].ToString() }

            };
            Repository.Add<Question>(question);
        }

        [When(@"I Query by Question (.*)")]
        public void WhenIQueryByQuestion(string questionTitle)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the result should be a valid Question Model")]
        public void ThenTheResultShouldBeAValidQuestionModel()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
