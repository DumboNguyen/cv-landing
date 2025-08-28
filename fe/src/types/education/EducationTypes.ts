import type { BaseEntity } from '../common/BaseTypes';

export interface Education extends BaseEntity {
  degree: string;
  field: string;
  institution: string;
  location: string;
  startDate: Date;
  endDate?: Date;
  isCurrent: boolean;
  description: string;
  gpa?: number;
  achievements?: string[];
}
