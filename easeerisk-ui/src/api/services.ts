import axios, { AxiosResponse } from 'axios';
import { RiskAssessment, CreateRiskAssessmentRequest, RiskIndicatorGroup, CreateRiskIndicatorGroup, RiskAssessmentTemplate, CreateRiskAssessmentTemplate } from './types';

// Define the base URL of your API if it's different from the default localhost port.
const API_BASE_URL = 'http://localhost:5020';
//const API_BASE_URL = process.env.REACT_APP_API_BASE_URL || 'http://localhost:5000';

// Common Axios instance to be shared among all services.
const axiosInstance = axios.create({
    baseURL: API_BASE_URL,
});

// RiskService Class
class RiskService {
    static getRiskAssessments(): Promise<AxiosResponse<RiskAssessment[]>> {
        return axiosInstance.get('/api/risk/assessments');
    }

    static createRiskAssessment(data: CreateRiskAssessmentRequest): Promise<AxiosResponse<RiskAssessment>> {
        return axiosInstance.post('/api/risk/assessments', data);
    }

    static updateRiskAssessment(id: string, data: RiskAssessment): Promise<AxiosResponse<RiskAssessment>> {
        return axiosInstance.put(`/api/risk/assessments/${id}`, data);
    }

    static deleteRiskAssessment(id: string): Promise<AxiosResponse<boolean>> {
        return axiosInstance.delete(`/api/risk/assessments/${id}`);
    }
}

// IndicatorGroupService Class
class IndicatorGroupService {
    static getIndicatorGroups(): Promise<AxiosResponse<RiskIndicatorGroup[]>> {
        return axiosInstance.get('/api/risk/indicator-groups');
    }

    static createIndicatorGroup(data: CreateRiskIndicatorGroup): Promise<AxiosResponse<RiskIndicatorGroup>> {
        return axiosInstance.post('/api/risk/indicator-groups', data);
    }

    static updateIndicatorGroup(id: string, data: RiskIndicatorGroup): Promise<AxiosResponse<RiskIndicatorGroup>> {
        return axiosInstance.put(`/api/risk/indicator-groups/${id}`, data);
    }

    static deleteIndicatorGroup(id: string): Promise<AxiosResponse<boolean>> {
        return axiosInstance.delete(`/api/risk/indicator-groups/${id}`);
    }
}

// TemplateService Class
class TemplateService {
    static getTemplates(): Promise<AxiosResponse<RiskAssessmentTemplate[]>> {
        return axiosInstance.get('/api/risk/templates');
    }

    static createTemplate(data: CreateRiskAssessmentTemplate): Promise<AxiosResponse<RiskAssessmentTemplate>> {
        return axiosInstance.post('/api/risk/templates', data);
    }

    static updateTemplate(id: string, data: RiskAssessmentTemplate): Promise<AxiosResponse<RiskAssessmentTemplate>> {
        return axiosInstance.put(`/api/risk/templates/${id}`, data);
    }

    static deleteTemplate(id: string): Promise<AxiosResponse<boolean>> {
        return axiosInstance.delete(`/api/risk/templates/${id}`);
    }
}

export { RiskService, IndicatorGroupService, TemplateService };
