import React, { useState } from "react";

const NavigationComponent = ({sendDataToParent}) => {
  
  const [current, setCurrent] = useState(0);
  
  const handleFirst = () => setCurrent(0);
  const handlePrevious = () => setCurrent((prev) => (prev > 0 ? prev - 1 : prev));
  const handleNext = () => setCurrent((prev) => (prev < questions.length - 1 ? prev + 1 : prev));
  const handleLast = () => setCurrent(questions.length - 1);

  
  return (
    <div>
      <h3>Navigation</h3>
      <hr />
      <div>
        

            <div>
              <button onClick={handleFirst} disabled={ sendDataToParent(current) === 0}>First</button>
              <button onClick={handlePrevious} disabled={sendDataToParent(current) === 0}>Previous</button>
              <button onClick={handleNext} disabled={sendDataToParent(current) === questions.length - 1}>Next</button>
              <button onClick={handleLast} disabled={sendDataToParent(current) === questions.length - 1}>Last</button>
            </div>

            
          </div>
        </div>
  );
};

export default NavigationComponent;
