import { endpoints } from '../config/apiEndpoitnts';

class CandidateService {
    
    async getCandidateDetails(candidateId, testId) {
      try {
        const response = await fetch(endpoints.getCandidateScore(candidateId, testId));
        return await this.handleResponse(response);
      } catch (error) {
        console.error('Error fetching candidate details:', error);
        throw error;
      }
    }
    async handleResponse(response) {
      if (!response.ok) {
        throw new Error(`Error: ${response.statusText}`);
      }
      return response.json();
    }


  async getTestResultDetails(testId) {
    try {
      const response = await fetch(endpoints.getTestResultDetails(testId));
      return await this.handleResponse(response);
    } catch (error) {
      console.error('Error fetching candidates:', error);
      throw error;
    }
  }

  async getTestResultDetails(subjectId) {
    try {
      const response = await fetch(endpoints.getTestResultDetails(testId));
      return await this.handleResponse(response);
    } catch (error) {
      console.error('Error fetching candidates:', error);
      throw error;
    }
  }

  async getAllCandidates(subjectId){
    
    try {
      const response = await fetch(endpoints.getAllCandidates(subjectId));
      return await this.handleResponse(response);
    } catch (error) {
      console.error('Error fetching candidates:', error);
      throw error;
    }



  }
  async getAllSubjects() {
    try {
      const response = await fetch(endpoints.getAllSubjects());
      return await this.handleResponse(response);
    } catch (error) {
      console.error('Error fetching subjects:', error);
      throw error;
    }
  }
  async handleResponse(response) {
    if (!response.ok) {
      throw new Error(`Error: ${response.statusText}`);
    }
    return response.json();
  }

  }
  export default new CandidateService();
  