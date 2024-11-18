// types.ts: Type definitions for the EaseeRisk API

// RiskAssessment Interface
export interface RiskAssessment {
    id: string;
    name: string;
    category: string;
    description: string;
}

// RiskIndicatorGroup Interface
export interface RiskIndicatorGroup {
    id: string;
    name: string;
}

// RiskAssessmentTemplate Interface
export interface RiskAssessmentTemplate {
    id: string;
    name: string;
    category: string;
    description: string;
}

// CreateRiskAssessmentRequest Interface
export interface CreateRiskAssessmentRequest {
    name: string;
    category: string;
    description: string;
}

// CreateRiskIndicatorGroup Interface
export interface CreateRiskIndicatorGroup {
    name: string;
}

// CreateRiskAssessmentTemplate Interface
export interface CreateRiskAssessmentTemplate {
    name: string;
    category: string;
    description: string;
}
