import React, { useEffect, useState } from 'react';
import { TemplateService } from '../api/services';
import { RiskAssessmentTemplate, CreateRiskAssessmentTemplate } from '../api/types';

// RiskAssessmentTemplateTable Component
const RiskAssessmentTemplateTable: React.FC = () => {
    const [templates, setTemplates] = useState<RiskAssessmentTemplate[]>([]);
    const [newTemplate, setNewTemplate] = useState<CreateRiskAssessmentTemplate>({ name: '', category: '', description: '' });

    useEffect(() => {
        TemplateService.getTemplates()
            .then(response => {
                setTemplates(response.data);
            })
            .catch(error => {
                console.error('Error fetching templates:', error);
            });
    }, []);

    const handleAddTemplate = () => {
        TemplateService.createTemplate(newTemplate)
            .then(response => {
                setTemplates([...templates, response.data]);
                setNewTemplate({ name: '', category: '', description: '' });
            })
            .catch(error => {
                console.error('Error adding template:', error);
            });
    };

    return (
        <div>
            <h2>Risk Assessment Templates</h2>
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
                    {templates.map(template => (
                        <tr key={template.id}>
                            <td>{template.id}</td>
                            <td>{template.name}</td>
                            <td>{template.category}</td>
                            <td>{template.description}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
            <div>
                <h3>Add New Template</h3>
                <input
                    type="text"
                    placeholder="Name"
                    value={newTemplate.name}
                    onChange={(e) => setNewTemplate({ ...newTemplate, name: e.target.value })}
                />
                <input
                    type="text"
                    placeholder="Category"
                    value={newTemplate.category}
                    onChange={(e) => setNewTemplate({ ...newTemplate, category: e.target.value })}
                />
                <input
                    type="text"
                    placeholder="Description"
                    value={newTemplate.description}
                    onChange={(e) => setNewTemplate({ ...newTemplate, description: e.target.value })}
                />
                <button onClick={handleAddTemplate}>Add Template</button>
            </div>
        </div>
    );
};

export default RiskAssessmentTemplateTable;
