import React, { useEffect, useState } from 'react';
import { IndicatorGroupService } from '../api/services';
import { RiskIndicatorGroup, CreateRiskIndicatorGroup } from '../api/types';

// RiskIndicatorGroupTable Component
const RiskIndicatorGroupTable: React.FC = () => {
    const [groups, setGroups] = useState<RiskIndicatorGroup[]>([]);
    const [newGroup, setNewGroup] = useState<CreateRiskIndicatorGroup>({ name: '' });

    useEffect(() => {
        IndicatorGroupService.getIndicatorGroups()
            .then(response => {
                setGroups(response.data);
            })
            .catch(error => {
                console.error('Error fetching indicator groups:', error);
            });
    }, []);

    const handleAddGroup = () => {
        IndicatorGroupService.createIndicatorGroup(newGroup)
            .then(response => {
                setGroups([...groups, response.data]);
                setNewGroup({ name: '' });
            })
            .catch(error => {
                console.error('Error adding indicator group:', error);
            });
    };

    return (
        <div>
            <h2>Risk Indicator Groups</h2>
            <table>
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Name</th>
                    </tr>
                </thead>
                <tbody>
                    {groups.map(group => (
                        <tr key={group.id}>
                            <td>{group.id}</td>
                            <td>{group.name}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
            <div>
                <h3>Add New Indicator Group</h3>
                <input
                    type="text"
                    placeholder="Name"
                    value={newGroup.name}
                    onChange={(e) => setNewGroup({ ...newGroup, name: e.target.value })}
                />
                <button onClick={handleAddGroup}>Add Group</button>
            </div>
        </div>
    );
};

export default RiskIndicatorGroupTable;