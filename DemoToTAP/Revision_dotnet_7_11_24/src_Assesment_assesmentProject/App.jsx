import React from 'react';
// import './App.css';
  import AssessmentList from './Assessment/Components/AssessmentList';
// import CreateTestComponent from './Assessment/Components/CreateNewTest';
// import EmployeesList from './Assessment/Components/EmployeesList';
 import AssessmentDetails from './Assessment/Components/AssessmentDetails';
import TestAppear from './Assessment/Components/TestAppear';
import CandidateDetails from './CandidateResultDetails/components/CandidateDetails';
// import GetAllQuestions from './QuestionBank/components/AllQuestions';
// import GetQuestionById from './QuestionBank/components/GetQuestionById';
// import GetAllQuestions from './QuestionBank/components/GetAllQuestions';
// import GetQuestionsByTestId from './QuestionBank/components/GetQuestionsByTestId';
// import QuestionList from './QuestionBank/components/GetQuestions';
// import InterviewSubjects from './InterviewDetails/components/GetInterviewedCandidatesSubjects';
// import InterviewList from './InterviewDetails/components/GetAllInterviewCandidates';
// import InterviewDeatils from './InterviewDetails/components/GetInterviewDetails';
// import GetCandidateResults from './AssementIntellegence/Components/GetCandidateResult';
// import InsertCriteria from './EvaluationCriteria/Component/Crud/InsertCriteria';
// import QuestionBankList from './testAppear_Shubhangi/Component/AppearTest';
// import ChangeInterviewerComponent from './InterviewDetails/components/ChangeInterviewer';
// import CancelInterviewComponent from './InterviewDetails/components/CancelInterview';
// import InsertCriteria from './EvaluationCriteria/Component/Crud/InsertCriteria';
// import SubjectMatterExpertDetails from './Assessment/Components/GetAllBySME';
// import CreateTestComponent from './Assessment/Components/CreateNewTest';
//import TestAppear from './Assessment/Components/TestAppear';
//import CandidateDetails from './CandidateResultDetails/components/CandidateDetails';
import CandidatesList from './CandidateResultDetails/components/CandidatesByTest';
//import SubjectCriteriaQuestions from './QuestionBank/components/SubjectCriteriaQuestions';

function App() {

  return (
    <>
      {/* <AssessmentList /> */}
     {/* <AssessmentDetails />  */}/
     {/* <TestAppear/> */}
     {/* <CandidateDetails/> */}
     
     <CandidatesList/>
      
    </>
  )
}

 export default App;

// import React from 'react';
// import { Provider } from 'react-redux';
// import store from './QuestionBank/redux/store';
// import './App.css';
// //import SubjectCriteriaQuestions from './QuestionBank/components/SubjectCriteriaQuestions';
// import GetAllQuestions from './QuestionBank/components/AllQuestions';
// import GetQuestionById from './QuestionBank/components/QuestionById';
// import GetQuestionsByTestId from './QuestionBank/components/QuestionsByTestId';

// function App() {
//   return (
//     <>
//       <Provider store={store}>
//         {/* <GetAllQuestions />  */}
//           {/* <SubjectCriteriaQuestions/> */}
//           {/* <GetQuestionById/> */}
//           <GetQuestionsByTestId/>
//       </Provider>
//     </>
//   );
// }

// export default App;


{/* <AssessmentList/> */}
      {/* <InterviewList/> 
      {/* <InterviewDeatils/> */}
      {/*<GetCandidateResults/>*/}
      {/* <InsertCriteria/> */}
      {/* <QuestionBankList/> */}
      {/*<CandidateDetails/> */}
      {/* <CandidatesList/> */}
      {/* <CreateTestComponent/>  */}
      {/* <EmployeesList/> */}
      {/* <AssessmentDetails /> */}