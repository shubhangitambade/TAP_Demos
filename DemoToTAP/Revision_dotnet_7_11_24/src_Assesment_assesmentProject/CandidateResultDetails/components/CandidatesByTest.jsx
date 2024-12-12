import { useEffect, useState } from "react";
import CandidateDetailsService from "../services/CandidateDetailsService";

const CandidatesList = () => {
  const [candidates, setCandidates] = useState([]);
  const [subjects, setSubjects] = useState([]);
  const [selectedSubject, setSelectedSubject] = useState();
  const [error, setError] = useState(null);

  useEffect(() => {
    const fetchSubjects = async () => {
        try {
            const data = await CandidateDetailsService.getAllSubjects();
            setSubjects(data);
        } catch (error) {
            setError('Failed to fetch subjects.');
        }
    };
    fetchSubjects();
}, []);

const fetchCandidates = async () => {
  //setLoading(true);
  setError(null);
  try {
    console.log(selectedSubject);
    const data = await CandidateDetailsService.getAllCandidates(selectedSubject);
    setCandidates(data);
    /*if (data.length > 0) {
      setSelectedSubject(data[0].id); 
    }*/
  } catch (error) {
    setError('Error fetching candidates...');
  } finally {
    //setLoading(false);
  }
};



const handleSubjectChange = async (event) => {
  const subjectId = event.target.value;
  console.log(subjectId);
  setSelectedSubject(subjectId);

};
  const handleSubmit = (e) => {
    e.preventDefault();
    fetchCandidates();
  };

  if (error) return <p>{error}</p>;

  return (
    <>
      <h2>Candidates According to Test</h2>
      <form onSubmit={handleSubmit}>

        <div>
          <label htmlFor="subjectSelect">Subjects:</label>
          <select id="subjectSelect" onChange={handleSubjectChange} defaultValue="">
            <option value="" disabled>Select a subject</option>
            {subjects.map(subject => (
              <option key={subject.id} value={subject.id}>
                {subject.title}
              </option>
            ))}
          </select>
        </div>

        <button type="submit">Submit</button>

        {/* <div>
          <label>Test ID: </label>
          <input type="text" value={testId} onChange={(e) => setTestId(e.target.value)} placeholder="Enter Test ID" required />
        </div>
            <button type="submit">Submit</button> */}
      </form>

      {candidates.length > 0 ? (
        <ol>
          {candidates.map((candidate) => (
            <li key={candidate.id}>
              {candidate.testid}  {candidate.candidateId} {candidate.firstName} {candidate.lastName} {candidate.score}
            </li>
          ))}
        </ol>
      ) : (
        <p>No candidates found</p>
      )}
    </>
  );
};

export default CandidatesList;
