// src/config/apiConfig.js

const API_BASE_URL = import.meta.env.VITE_API_BASE_URL;

const endpoints = {
  getCandidatesByTestId: (testId) => `${API_BASE_URL}/Result/candidates/tests/${testId}`,
  getCandidateScore: (candidateId, testId) => `${API_BASE_URL}/Result/candidates/${candidateId}/tests/${testId}/score`,
  setCandidateTestStartTime: (candidateId, testId) => `${API_BASE_URL}/Result/setstarttime/${candidateId}/tests/${testId}`,
  setCandidateTestEndTime: (candidateId, testId) => `${API_BASE_URL}/Result/setendtime/${candidateId}/tests/${testId}`,
  getCandidateResultDetails: (candidateId, testId) => `${API_BASE_URL}/Result/candidates/${candidateId}/tests/${testId}/details`,
  getTestResultDetails: (testId) => `${API_BASE_URL}/Result/tests/${testId}/details`,
  getAppearedCandidates: (testId) => `${API_BASE_URL}/Result/candidates/tests/${testId}`,

  getAllSubjects: () => `${API_BASE_URL}/Result/subjects`,
  getAllCandidates:(subjectId) =>`${API_BASE_URL}/Result/results/subjectresults/${subjectId}`
};

export { API_BASE_URL, endpoints };
