import React from 'react';
import RiskAssessmentList from '../components/riskassessmentlist';
import RiskIndicatorGroupList from '../components/riskindicatorgrouplist';
import RiskAssessmentTemplateList from '../components/riskassessmenttemplatelist';

const HomePage: React.FC = () => {
    return (
        <div>
        <h1>Welcome to EaseeRisk </h1>
            < div style = {{ marginBottom: '2rem' }
}>
    <RiskAssessmentList />
    </div>
    < div style = {{ marginBottom: '2rem' }}>
        <RiskIndicatorGroupList />
        </div>
        < div style = {{ marginBottom: '2rem' }}>
            <RiskAssessmentTemplateList />
            </div>
            </div>
  );
};

export default HomePage;
