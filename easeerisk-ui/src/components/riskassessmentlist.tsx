import React, { useEffect, useState } from 'react';
import { RiskService } from '../api/services';
import { RiskAssessment, CreateRiskAssessmentRequest } from '../api/types';

// RiskAssessmentTable Component
const RiskAssessmentTable: React.FC = () => {
    const [assessments, setAssessments] = useState<RiskAssessment[]>([]);
    const [newAssessment, setNewAssessment] = useState<CreateRiskAssessmentRequest>({ name: '', category: '', description: '' });

    useEffect(() => {
        RiskService.getRiskAssessments()
            .then(response => {
                setAssessments(response.data);
            })
            .catch(error => {
                console.error('Error fetching risk assessments:', error);
            });
    }, []);

    const handleAddAssessment = () => {
        RiskService.createRiskAssessment(newAssessment)
            .then(response => {
                setAssessments([...assessments, response.data]);
                setNewAssessment({ name: '', category: '', description: '' });
            })
            .catch(error => {
                console.error('Error adding risk assessment:', error);
            });
    };

    return (
        <div>
            <h2>Risk Assessments</h2>
            <table>
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Name</th>
                        <th>Category</th>
                        <th>Description</th>
                    </tr>
                </thead>
                <tbody>
                    {assessments.map(assessment => (
                        <tr key={assessment.id}>
                            <td>{assessment.id}</td>
                            <td>{assessment.name}</td>
                            <td>{assessment.category}</td>
                            <td>{assessment.description}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
            <div>
                <h3>Add New Risk Assessment</h3>
                <input
                    type="text"
                    placeholder="Name"
                    value={newAssessment.name}
                    onChange={(e) => setNewAssessment({ ...newAssessment, name: e.target.value })}
                />
                <input
                    type="text"
                    placeholder="Category"
                    value={newAssessment.category}
                    onChange={(e) => setNewAssessment({ ...newAssessment, category: e.target.value })}
                />
                <input
                    type="text"
                    placeholder="Description"
                    value={newAssessment.description}
                    onChange={(e) => setNewAssessment({ ...newAssessment, description: e.target.value })}
                />
                <button onClick={handleAddAssessment}>Add Assessment</button>
            </div>
        </div>
    );
};

export default RiskAssessmentTable;